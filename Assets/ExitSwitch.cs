using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExitSwitch : MonoBehaviour
{

    public UnityEvent doorswitch1;

    // Start is called before the first frame update
    void Start()
    {
        if(doorswitch1 == null){
            doorswitch1 = new UnityEvent(); 
        }
        doorswitch1.AddListener(DoorSwitch1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DoorSwitch1(){
        Debug.Log("you have escaped");
    }

    void OnTriggerStay2D(Collider2D other){
        if(other.gameObject.tag == "Player" && Input.GetButtonDown("Fire1"))
        {
            doorswitch1.Invoke();
        }
    }    

    public void OpenDoor(){
            doorswitch1.Invoke();
    } 
}