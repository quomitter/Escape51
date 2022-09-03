using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExitSwitch : MonoBehaviour
{
    private PlayerController playerController; 
    public UnityEvent doorSwitchExit;

    // Start is called before the first frame update
    void Start()
    {
        if(doorSwitchExit == null){
            doorSwitchExit = new UnityEvent(); 
        }
        doorSwitchExit.AddListener(DoorSwitch1);
        playerController = FindObjectOfType<PlayerController>(); 
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void DoorSwitch1(){
        if(playerController.hasRescuedBlue){
            Debug.Log("you have escaped");
        }else{
            Debug.Log("you have to rescue blue");
        }
        
    }

    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag == "Player" && Input.GetButtonDown("Fire1"))
        {
            doorSwitchExit.Invoke();
        }
    }    

    public void OpenDoor(){
            doorSwitchExit.Invoke();
    } 
}