using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTurrent : MonoBehaviour
{

    public Rigidbody2D autoTurrent;
    public Transform firePoint;
    public GameObject bullet;
    public float bulletSpeed;
    private bool m_FacingRight;
    public float fireRate = 0.2f;
    public float lastShot = 0f;

    public Transform playerTarget; 

    private PlayerHealthController playerHealthController;
    AudioSource audioSource; 
    public AudioClip enemyLazerSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
        playerHealthController = GameObject.Find("Alien_Green").GetComponent<PlayerHealthController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance( playerTarget.transform.position, this.transform.position) < 10){
        if (Time.time > fireRate + lastShot)
        {
            audioSource.PlayOneShot(enemyLazerSound, 0.45f);
            GameObject clone = Instantiate(bullet, firePoint.position, firePoint.rotation);
            Physics2D.IgnoreCollision(clone.GetComponent<Collider2D>(), autoTurrent.GetComponent<Collider2D>());
            Rigidbody2D shot = clone.GetComponent<Rigidbody2D>();
            if (!m_FacingRight)
                shot.AddForce(-transform.right * bulletSpeed, ForceMode2D.Impulse);
            else
                shot.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);
            Destroy(clone.gameObject, 1f);
            lastShot = Time.time;
        }}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);

        }
        if (collision.gameObject.tag == "Player")
        {
            playerHealthController.DamagePlayer(1);
        }
    }
}
