using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] GameObject enemyBullet;
    [SerializeField] Transform firePoint;
    [SerializeField] Vector2 playerTarget;
    [SerializeField] float fireRateCoolDown;
    

    // Start is called before the first frame update
    void Start()
    {
        fireRateCoolDown = 2f;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (fireRateCoolDown > 0)
        {
            fireRateCoolDown -= Time.deltaTime;
            if (fireRateCoolDown < 0)
            {
                Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
                fireRateCoolDown = 2f; 

            }
        }
    }
}
