using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSceneRoom16 : MonoBehaviour
{

    public bool isInRoom16;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            
            isInRoom16 = true;
        }
    }
    //private void OnTriggerStay2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
            
            
    //    }
    //}
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            isInRoom16 = false;
    }

}
