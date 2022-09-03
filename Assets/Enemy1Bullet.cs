using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Bullet : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D thisRB;

    public int damageAmount;
    //public GameObject impactEffect;

    public PlayerController playerController;
    public PlayerHealthController playerHealthController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Alien_Green").GetComponent<PlayerController>();
        playerHealthController = GameObject.Find("Alien_Green").GetComponent<PlayerHealthController>();

        Vector3 direction = transform.position - playerController.transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //AudioManager.instance.PlaySFXAdjusted(2);
    }

    // Update is called once per frame
    void Update()
    {
        thisRB.velocity = -transform.right * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           playerHealthController.DamagePlayer(damageAmount);
        }

        //if (impactEffect != null)
        //{
            //Instantiate(impactEffect, transform.position, transform.rotation);

            Destroy(gameObject);
       // }

       // AudioManager.instance.PlaySFXAdjusted(3);
    }
}
