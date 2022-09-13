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
    public Transform wallCheck;
    public LayerMask whatIsGround;
    public TMP_Text deathText;
    public Canvas pauseCanvas;

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
    public bool isTouchingWall;
    public float staminaTimer = 1f;
    public float fillStaminaTimer = 1f;
    public bool isPaused;
    public bool isWallSliding;

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
        isPaused = false;
        canRollCoolDown = 0;
        canRollTimer = canRollTimeLeft;
        isDead = false;
        playerHealthController = GameObject.Find("Alien_Green").GetComponent<PlayerHealthController>();
        anim.SetBool("isDead", false);
        pauseCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPaused)
        {
            if (!isInUI)
            {
                if (!isDead)
                {
                    staminaTimer -= Time.deltaTime;
                    fillStaminaTimer -= Time.deltaTime;
                    isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, whatIsGround);
                    isTouchingWall = Physics2D.OverlapCircle(wallCheck.position, 0.1f, whatIsGround);
                    playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);
                    if (playerRB.velocity.x > 1 || playerRB.velocity.x < -1)
                    {
                        anim.SetBool("isWalking", true);
                    }
                    else
                    {
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

                    if (Input.GetButtonDown("Jump") && jumpCounter < 2 && playerHealthController.currentStamina > 0)
                    {
                        if (!isWallSliding)
                        {
                            audioSource.PlayOneShot(jumpSound, 0.35f);
                            playerHealthController.ReduceStamina();
                            playerRB.AddForce(new Vector2(playerRB.velocity.x, jumpForce), ForceMode2D.Force);
                        }
                        else
                        {
                            audioSource.PlayOneShot(jumpSound, 0.35f);
                            playerHealthController.ReduceStamina();
                            playerRB.AddForce(new Vector2(playerRB.velocity.x, jumpForce), ForceMode2D.Force);
                        }


                    }
                    else if (isGrounded || isTouchingWall)
                    {
                        jumpCounter = 0;
                    }
                    if (Input.GetButtonUp("Jump"))
                    {
                        jumpCounter++;
                    }

                    if (System.Convert.ToBoolean(Input.GetAxis("RightTrigger")) && !isRolling)
                    {
                        anim.SetBool("isShooting", true);
                        if (Time.time > fireRate + lastShot)
                        {

                            GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject();
                            if (bullet != null)
                            {
                                bullet.transform.position = firePoint.transform.position;
                                bullet.transform.rotation = firePoint.transform.rotation;
                                bullet.SetActive(true);
                                if (!m_FacingRight)
                                {
                                    audioSource.PlayOneShot(gunSound, 0.35f);
                                    bullet.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
                                }
                                else
                                {
                                    audioSource.PlayOneShot(gunSound, 0.35f);
                                    bullet.GetComponent<Rigidbody2D>().AddForce(-transform.right * bulletSpeed, ForceMode2D.Impulse);
                                }
                            }

                            // GameObject clone = Instantiate(laserShot, firePoint.position, firePoint.rotation);
                            // Physics2D.IgnoreCollision(clone.GetComponent<Collider2D>(), playerRB.GetComponent<Collider2D>());
                            // Rigidbody2D shot = clone.GetComponent<Rigidbody2D>();
                            // if (!m_FacingRight)
                            //     shot.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
                            // else
                            //     shot.AddForce(-transform.right * bulletSpeed, ForceMode2D.Impulse);
                            // Destroy(clone.gameObject, 1f);
                            lastShot = Time.time;
                        }
                    }
                    else
                    {
                        anim.SetBool("isShooting", false);
                    }


                    if (Input.GetButtonUp("Fire2"))
                    {
                        playerHealthController.ReduceStamina();
                        playerHealthController.ReduceStamina();
                        canRollTimer = canRollTimeLeft;
                    }
                    if (Input.GetButton("Fire2") && canRollTimer > 0 && canRollCoolDown < 0 && playerHealthController.currentStamina > 0)
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
                    if (Input.GetButton("Fire3") && playerHealthController.currentStamina > 0)
                    {
                        if (staminaTimer < 0)
                        {
                            playerHealthController.ReduceStamina();
                            staminaTimer = 1f;
                        }
                        moveSpeed = 16f;
                    }
                    else
                    {
                        moveSpeed = 8f;
                    }
                    if (fillStaminaTimer < 0)
                    {
                        playerHealthController.FillStamina();
                        fillStaminaTimer = 1f;
                    }
                    if (isTouchingWall && !isGrounded)
                    {
                        isWallSliding = true;
                    }
                    else
                    {
                        isWallSliding = false;
                    }
                    // if (isWallSliding)
                    // {
                    //     playerRB.velocity = new Vector2(playerRB.velocity.x, Mathf.Clamp(playerRB.velocity.y, 0.3f, float.MaxValue));
                    // }

                }
            }

        }


        if (Input.GetButtonDown("Start"))
        {
            isPaused = !isPaused;
        }
        if (isPaused)
        {
            Time.timeScale = 0;
            pauseCanvas.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pauseCanvas.gameObject.SetActive(false);
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
