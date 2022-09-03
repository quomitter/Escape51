using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSceneRoom30 : MonoBehaviour
{

    public bool isInRoom30;
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
            
            isInRoom30 = true;
        }
    }
    //private void OnTriggerStay2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
            
    //        isInRoom24 = true;
    //    }
    //}
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            isInRoom30 = false;
    }

}
