using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSceneRoom37 : MonoBehaviour
{

    public bool isInRoom37;
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
            
            isInRoom37 = true;
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
            isInRoom37 = false;
    }

}
