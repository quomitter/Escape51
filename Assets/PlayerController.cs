using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip gunSound;
    public Animator anim;

    public Rigidbody2D playerRB;
    public GameObject laserShot;
    public Transform firePoint;
    public Transform groundCheck;
    public LayerMask whatIsGround;
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

    public float inAirCounter;

    int activeSceneIndex;
    public bool hasRescuedBlue;
    public bool isGrounded; 

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hasRescuedBlue = false;
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
        if (!isInUI)
        {
            if (!isDead)
            {
                isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, whatIsGround);
                playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);
                if(playerRB.velocity.x > 1 || playerRB.velocity.x < -1){
                    anim.SetBool("isWalking", true);
                }else{
                    anim.SetBool("isWalking", false);
                }

                if (playerRB.velocity.x > 0 && m_FacingRight)
                {
                    Flip();
                }
                else if (playerRB.velocity.x < 0 && !m_FacingRight)
                {
                    Flip();
                }

                if (Input.GetButtonDown("Jump") && jumpCounter < 2)
                {
                    audioSource.PlayOneShot(jumpSound, 0.35f);
                    playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
                    
                }else if(isGrounded){
                    jumpCounter = 0; 
                }
                if(Input.GetButtonUp("Jump")){
                    jumpCounter++; 
                }

                if (System.Convert.ToBoolean(Input.GetAxis("RightTrigger")) && !isRolling)
                {
                    anim.SetBool("isShooting", true);
                    if (Time.time > fireRate + lastShot)
                    {
                        audioSource.PlayOneShot(gunSound, 0.35f);
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

            }
        }
        else{
                playerRB.velocity = new Vector2(0,0); 
        }


        if (playerHealthController.currentHealth <= 0)
        {
            isDead = true;
            anim.SetBool("isDead", true);
        }

        if (isDead == true)
        {
            isDeadCounter += Time.deltaTime;
            deathText.transform.position = playerRB.transform.position;
            deathText.gameObject.SetActive(true);
            playerRB.constraints = RigidbodyConstraints2D.FreezeRotation;
            playerRB.constraints = RigidbodyConstraints2D.FreezePosition;
            if (isDeadCounter > 5)
            {
                SceneManager.LoadScene(activeSceneIndex);
            }
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
