using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CageTrigger : MonoBehaviour
{

    private PlayerController controller;
    private GameObject theCage;

    public TMP_Text endText;
     

    private void Start()
    {
        controller = GameObject.Find("Alien_Green").GetComponent<PlayerController>();
        theCage = GameObject.Find("AlienCage");
        endText.gameObject.SetActive(false);
        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            controller.playerRB.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            theCage.transform.position = controller.playerRB.position;
            endText.gameObject.SetActive(true);
          
        }
    }

}
