using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] GameObject enemyBullet;
    [SerializeField] Transform firePoint;
    [SerializeField] Transform playerTarget;
    [SerializeField] float fireRateCoolDown;
    AudioSource audioSource; 
     public AudioClip enemyLazerSound; 
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
        fireRateCoolDown = 2f;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance( playerTarget.transform.position, this.transform.position) < 10){
        if (fireRateCoolDown > 0)
        {
            fireRateCoolDown -= Time.deltaTime;
            if (fireRateCoolDown < 0)
            {
                audioSource.PlayOneShot(enemyLazerSound, 0.45f);
                Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
                fireRateCoolDown = 2f; 

            }
        }}
    }
}
