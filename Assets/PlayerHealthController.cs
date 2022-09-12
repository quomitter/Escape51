using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthController : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip hurtSound;

    PlayerController playerController;
    public int currentHealth;
    public int maxHealth = 10;

    public float invincibilityLength;
    private float invincCounter;

    public float flashLength;
    private float flashCounter;
    public int currentStamina;
    public int maxStamina = 10; 

    // Start is called before the first frame update
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        currentHealth = maxHealth;
        currentStamina = maxStamina; 
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DamagePlayer(int damageAmount)
    {
        if (!playerController.isRolling)
        {
            audioSource.PlayOneShot(hurtSound, 0.45f);
            currentHealth -= damageAmount;

            if (currentHealth <= 0)
            {
                currentHealth = 0;

            }
        }



    }
    public void FillHealth()
    {
        currentHealth = maxHealth;

    }

    public void FillStamina(){
        if(currentStamina < 10)
            currentStamina++; 
    }
    public void ReduceStamina(){
        if(currentStamina > 0)
            currentStamina -= 1; 
    }
}
