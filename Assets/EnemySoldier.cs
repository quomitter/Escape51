using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoldier : MonoBehaviour
{
    public Rigidbody2D enemySoldier;
    public Transform firePoint;
    public GameObject bullet;
    public float bulletSpeed;
    private bool m_FacingRight;
    public float fireRate = 0.2f;
    public float lastShot = 0f;
    public Transform playerTarget; 
    AudioSource audioSource; 
    public AudioClip enemyLazerSound; 

    private PlayerHealthController playerHealthController; 

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
        playerHealthController = GameObject.Find("Alien_Green").GetComponent<PlayerHealthController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (enemySoldier.velocity.x > 0 && m_FacingRight)
        //{
        //    Flip();
        //}
        //else if (enemySoldier.velocity.x < 0 && !m_FacingRight)
        //{
        //    Flip();
        //}
       if(Vector2.Distance( playerTarget.transform.position, this.transform.position) < 10){
        if (Time.time > fireRate + lastShot)
        {
            audioSource.PlayOneShot(enemyLazerSound, 0.45f);
            GameObject clone = Instantiate(bullet, firePoint.position, firePoint.rotation);
            Physics2D.IgnoreCollision(clone.GetComponent<Collider2D>(), enemySoldier.GetComponent<Collider2D>());
            Rigidbody2D shot = clone.GetComponent<Rigidbody2D>();
            if (!m_FacingRight)
                shot.AddForce(-transform.right * bulletSpeed, ForceMode2D.Impulse);
            else
                shot.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
            Destroy(clone.gameObject, 1f);
            lastShot = Time.time;
            }}
    }

    private void FixedUpdate()
    {
        //enemySoldier.position = enemySoldier.position + new Vector2(0.1f * Mathf.Sin(Time.time), 0);
    }

    //private void Flip()
    //{
    //    m_FacingRight = !m_FacingRight;
    //    Vector3 theScale = transform.localScale;
    //    theScale.x *= -1;
    //    transform.localScale = theScale;
    //}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);
        }
        if(other.gameObject.tag == "Player")
        {
            playerHealthController.DamagePlayer(1);
        }
    }
}
