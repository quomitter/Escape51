using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Animator anim;

    public Rigidbody2D playerRB;
    public GameObject laserShot;
    public Transform firePoint;
    public TMP_Text deathText; 

    public Vector2 direction;

    public float bulletSpeed = 100f;

    public float moveSpeed;

    public int jumpCounter;
    public float jumpForce;

    public float fireRate = 0.2f;
    public float lastShot = 0f;
    public bool canShoot = false;
    public bool isRolling;
    public float canRollCoolDown;
    public bool m_FacingRight;
    public bool canRoll;
    public float canRollTimer;
    public float canRollTimeLeft = 1f;

    public bool isDead;
    public bool isInUI; 
    public PlayerHealthController playerHealthController;
    public float isDeadCounter;
    public bool isInAir;
    public float inAirCounter;

    int activeSceneIndex; 

    // Start is called before the first frame update
    void Start()
    {
        activeSceneIndex = SceneManager.GetActiveScene().buildIndex; 
        isInUI = false; 
        jumpCounter = 0;
        isDeadCounter = 0;
        canRoll = true;
        canRollCoolDown = 0;
        canRollTimer = canRollTimeLeft;
        isDead = false;
        playerHealthController = GameObject.Find("Alien_Green").GetComponent<PlayerHealthController>();
        anim.SetBool("isDead", false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isInUI){
        if (!isDead)
        {
            playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);

            if (playerRB.velocity.x > 0 && m_FacingRight)
            {
                Flip();
            }
            else if (playerRB.velocity.x < 0 && !m_FacingRight)
            {
                Flip();
            }

            if (Input.GetButtonDown("Jump") && jumpCounter < 1)
            {
                jumpCounter++;
                playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
            }


            if (Input.GetButton("Fire1") && !isRolling)
            {
                anim.SetBool("isShooting", true);
                if (Time.time > fireRate + lastShot)
                {
                    GameObject clone = Instantiate(laserShot, firePoint.position, firePoint.rotation);
                    Physics2D.IgnoreCollision(clone.GetComponent<Collider2D>(), playerRB.GetComponent<Collider2D>());
                    Rigidbody2D shot = clone.GetComponent<Rigidbody2D>();
                    if (!m_FacingRight)
                        shot.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
                    else
                        shot.AddForce(-transform.right * bulletSpeed, ForceMode2D.Impulse);
                    Destroy(clone.gameObject, 1f);
                    lastShot = Time.time;
                }
            }
            else
            {
                anim.SetBool("isShooting", false);
            }


            if (Input.GetButtonUp("Fire2"))
            {
                canRollTimer = canRollTimeLeft;
            }
            if (Input.GetButton("Fire2") && canRollTimer > 0 && canRollCoolDown < 0)
            {
                canRollTimer -= Time.deltaTime;
                anim.SetBool("isRolling", true);
                isRolling = true;
                if (canRollTimer < 0)
                {
                    canRollCoolDown = 1f;
                    canRollTimer = canRollTimeLeft;
                }


            }
            else
            {
                canRollCoolDown -= Time.deltaTime;
                anim.SetBool("isRolling", false);
                isRolling = false;
            }
            if (Input.GetButton("Fire3"))
            {
                moveSpeed = 16f;
            }
            else 
            { 
                moveSpeed = 8f; 
            }
                  
        }}


        if (isInAir)
        {
            inAirCounter += Time.deltaTime;
        }
        if(playerHealthController.currentHealth <= 0)
        {
            isDead = true;
            anim.SetBool("isDead", true);
        }
        if(isDead == true)
        {
            isDeadCounter += Time.deltaTime;
            deathText.transform.position = playerRB.transform.position;
            deathText.gameObject.SetActive(true);
            playerRB.constraints = RigidbodyConstraints2D.FreezeRotation;
            playerRB.constraints = RigidbodyConstraints2D.FreezePosition;
            if(isDeadCounter > 5)
            {
                SceneManager.LoadScene(activeSceneIndex);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (gameObject.tag == "Player" && other.gameObject.tag == "Ground")
        {
            jumpCounter = 0;
            isInAir = false;
            if(inAirCounter > 0.4f)
            {
                playerHealthController.currentHealth = playerHealthController.currentHealth - (int)inAirCounter * 2;
                playerHealthController.healthSlider.value = playerHealthController.currentHealth;
                inAirCounter = 0;
            }
            else
            {
                inAirCounter = 0;
            }

            
            
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (gameObject.tag == "Player" && other.gameObject.tag == "Ground")
        {
            isInAir = true;
        }
    }

    private void Flip()
    {
        m_FacingRight = !m_FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
