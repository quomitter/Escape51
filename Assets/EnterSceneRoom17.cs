using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSceneRoom17 : MonoBehaviour
{

    public bool isInRoom17;
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
            
            isInRoom17 = true;
        }
    }
    //private void OnTriggerStay2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
            
    //        isInRoom17 = true;
    //    }
    //}
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            isInRoom17 = false;
    }

}
