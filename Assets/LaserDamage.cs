using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDamage : MonoBehaviour
{

    float timeAlive = 5f; 
    private PlayerHealthController playerHealthController; 

    // Start is called before the first frame update
    void Start()
    {
        playerHealthController = GameObject.Find("Alien_Green").GetComponent<PlayerHealthController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        timeAlive -= Time.deltaTime; 
        if(timeAlive < 0){
            gameObject.SetActive(false);
            timeAlive = 5; 
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerHealthController.DamagePlayer(1);
            gameObject.SetActive(false);
        }
        gameObject.SetActive(false);
    }
}
