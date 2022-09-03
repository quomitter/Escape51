using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMaster : MonoBehaviour
{
    public EnterSceneRoom1 room1;
    public EnterSceneRoom2 room2;
    public EnterSceneRoom3 room3;
    public EnterSceneRoom4 room4;
    public EnterSceneRoom5 room5;
    public EnterSceneRoom6 room6;
    public EnterSceneRoom7 room7;
    public EnterSceneRoom8 room8;
    public EnterSceneRoom9 room9;
    public EnterSceneRoom10 room10;
    public EnterSceneRoom11 room11;
    public EnterSceneRoom12 room12;
    public EnterSceneRoom13 room13;
    public EnterSceneRoom14 room14;
    public EnterSceneRoom15 room15;
    public EnterSceneRoom16 room16;
    public EnterSceneRoom17 room17;
    public EnterSceneRoom18 room18;
    public EnterSceneRoom19 room19;
    public EnterSceneRoom20 room20;
    public EnterSceneRoom21 room21;
    public EnterSceneRoom22 room22;
    public EnterSceneRoom23 room23;
    public EnterSceneRoom24 room24;
    public EnterSceneRoom25 room25;
    public EnterSceneRoom26 room26;
    public EnterSceneRoom27 room27;
    public EnterSceneRoom28 room28;
    public EnterSceneRoom29 room29;
    public EnterSceneRoom30 room30;
    public EnterSceneRoom31 room31;
    public EnterSceneRoom32 room32;
    public EnterSceneRoom33 room33;
    public EnterSceneRoom34 room34;
    public EnterSceneRoom35 room35;
    public EnterSceneRoom36 room36;
    public EnterSceneRoom37 room37;
    public EnterSceneRoom38 room38;
    public EnterSceneRoom39 room39;
    public EnterSceneRoom40 room40;
    public EnterSceneRoom41 room41;
    public EnterSceneRoom42 room42;
    public EnterSceneRoom43 room43;
    public EnterSceneRoom44 room44;

    public EnterSceneRoom45 room45;

    /* public EnterSceneRoom24 room24; */

    public GameObject enemyOneInRoomTwo;
    public GameObject enemyTwoInRoomTwo;
    public GameObject enemyOneInRoomSix;
    public GameObject enemyOneInRoom12;
    public GameObject enemyTwoInRoom12;
    public GameObject enemyThreeInRoom12;
    public GameObject enemyOneInRoom13;
    public GameObject enemyTwoInRoom13;
    public GameObject enemyThreeInRoom13;
    public GameObject enemyOneInRoom16;
    public GameObject enemyOneInRoom22;
    public GameObject enemyTwoInRoom22;
    public GameObject enemyThreeInRoom22;
    
    public int RoomOneEnterCounter;
   
    public int RoomSixEnterCounter;
    public int Room12EnterCounter;
    public int Room13EnterCounter;
    public int Room16EnterCounter;
    public int Room22EnterCounter;

    public Camera theCamera;
    public Transform cameraTarget;
    public BoxCollider2D[] cameraBounds; 
    private float halfHeight;
    private float halfWidth;


    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.position = room1.gameObject.transform.position;
        RoomOneEnterCounter = 0;

        halfHeight = Camera.main.orthographicSize;
        halfWidth = Camera.main.orthographicSize * Camera.main.aspect; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        // Camera Control
        if(room1.isInRoom1 == true)
        {
            if(Camera.main.transform.position.x > room1.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
        }
        if (room2.isInRoom2 == true)
        {
            
            // if(Camera.main.transform.position.x < room2.gameObject.transform.position.x)
            // Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            // if (Camera.main.transform.position.x > room2.gameObject.transform.position.x)
            //     Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            theCamera.transform.position = new Vector3(cameraTarget.position.x, cameraTarget.position.y, -10f);
            theCamera.transform.position = new Vector3(Mathf.Clamp(theCamera.transform.position.x, cameraBounds[1].bounds.min.x + halfWidth, cameraBounds[1].bounds.max.x - halfWidth),
                Mathf.Clamp(theCamera.transform.position.y, cameraBounds[1].bounds.min.y + halfHeight, cameraBounds[1].bounds.max.y - halfHeight), -10f );
        }
        if (room3.isInRoom3 == true)
        {
            if (Camera.main.transform.position.x < room3.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room3.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room3.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room3.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room4.isInRoom4 == true)
        {
            if (Camera.main.transform.position.y < room4.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x , Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room4.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x , Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room5.isInRoom5 == true)
        {
            if (Camera.main.transform.position.x < room5.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room5.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room5.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room5.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room6.isInRoom6 == true)
        {
            if (Camera.main.transform.position.x < room6.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room6.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room6.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room6.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room7.isInRoom7 == true)
        {
            if (Camera.main.transform.position.x < room7.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room7.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room7.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room7.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room8.isInRoom8 == true)
        {
            if (Camera.main.transform.position.x < room8.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room8.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room8.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room8.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room9.isInRoom9 == true)
        {
            if (Camera.main.transform.position.x < room9.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room9.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room9.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room9.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room10.isInRoom10 == true)
        {
            if (Camera.main.transform.position.x < room10.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room10.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room10.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room10.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room11.isInRoom11 == true)
        {
            if (Camera.main.transform.position.x < room11.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room11.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room11.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room11.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room12.isInRoom12 == true)
        {
            if (Camera.main.transform.position.x < room12.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room12.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room12.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room12.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room13.isInRoom13 == true)
        {
            if (Camera.main.transform.position.x < room13.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room13.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room13.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room13.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room14.isInRoom14 == true)
        {
            if (Camera.main.transform.position.x < room14.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room14.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room14.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room14.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room15.isInRoom15 == true)
        {
            if (Camera.main.transform.position.x < room15.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room15.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room15.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room15.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room16.isInRoom16 == true)
        {
            if (Camera.main.transform.position.x < room16.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room16.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room16.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room16.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room17.isInRoom17 == true)
        {
            if (Camera.main.transform.position.x < room17.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room17.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room17.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room17.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room18.isInRoom18 == true)
        {
            if (Camera.main.transform.position.x < room18.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room18.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room18.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room18.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room19.isInRoom19 == true)
        {
            if (Camera.main.transform.position.x < room19.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room19.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room19.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room19.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room20.isInRoom20 == true)
        {
            if (Camera.main.transform.position.x < room20.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room20.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room20.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room20.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room21.isInRoom21 == true)
        {
            if (Camera.main.transform.position.x < room21.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room21.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room21.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room21.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room22.isInRoom22 == true)
        {
            if (Camera.main.transform.position.x < room22.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room22.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room22.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room22.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room23.isInRoom23 == true)
        {
            if (Camera.main.transform.position.x < room23.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room23.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room23.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room23.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room24.isInRoom24 == true)
        {
            if (Camera.main.transform.position.x < room24.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room24.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room24.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room24.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room25.isInRoom25 == true)
        {
            if (Camera.main.transform.position.x < room25.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room25.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room25.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room25.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room26.isInRoom26 == true)
        {
            if (Camera.main.transform.position.x < room26.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room26.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room26.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room26.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room27.isInRoom27 == true)
        {
            if (Camera.main.transform.position.x < room27.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room27.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room27.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room27.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room28.isInRoom28 == true)
        {
            if (Camera.main.transform.position.x < room28.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room28.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room28.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room28.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room29.isInRoom29 == true)
        {
            if (Camera.main.transform.position.x < room29.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room29.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room29.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room29.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room30.isInRoom30 == true)
        {
            if (Camera.main.transform.position.x < room30.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room30.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room30.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room30.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room31.isInRoom31 == true)
        {
            if (Camera.main.transform.position.x < room31.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room31.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room31.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room31.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room32.isInRoom32 == true)
        {
            if (Camera.main.transform.position.x < room32.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room32.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room32.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room32.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room33.isInRoom33 == true)
        {
            if (Camera.main.transform.position.x < room33.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room33.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room33.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room33.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room34.isInRoom34 == true)
        {
            if (Camera.main.transform.position.x < room34.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room34.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room34.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room34.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room35.isInRoom35 == true)
        {
            if (Camera.main.transform.position.x < room35.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room35.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room35.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room35.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room36.isInRoom36 == true)
        {
            if (Camera.main.transform.position.x < room36.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room36.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room36.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room36.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room37.isInRoom37 == true)
        {
            if (Camera.main.transform.position.x < room37.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room37.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room37.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room37.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room38.isInRoom38 == true)
        {
            if (Camera.main.transform.position.x < room38.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room38.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room38.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room38.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room39.isInRoom39 == true)
        {
            if (Camera.main.transform.position.x < room39.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room39.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room39.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room39.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room40.isInRoom40 == true)
        {
            if (Camera.main.transform.position.x < room40.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room40.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room40.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room40.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room41.isInRoom41 == true)
        {
            if (Camera.main.transform.position.x < room41.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room41.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room41.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room41.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room42.isInRoom42 == true)
        {
            if (Camera.main.transform.position.x < room42.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room42.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room42.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room42.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room43.isInRoom43 == true)
        {
            if (Camera.main.transform.position.x < room43.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room43.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room43.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room43.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room44.isInRoom44 == true)
        {
            if (Camera.main.transform.position.x < room44.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room44.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room44.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room44.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        }
        if (room45.isInRoom45 == true)
        {
            if (Camera.main.transform.position.x < room45.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room45.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room45.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room45.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        } 
/*         if (room24.isInRoom24 == true)
        {
            if (Camera.main.transform.position.x < room24.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.x > room24.gameObject.transform.position.x)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - 0.5f, Camera.main.transform.position.y, -10f);
            if (Camera.main.transform.position.y < room24.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + 0.5f, -10f);
            if (Camera.main.transform.position.y > room24.gameObject.transform.position.y)
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.5f, -10f);
        } */

        // enemy control
        if(room2.isInRoom2 == true && RoomOneEnterCounter < 1 && enemyOneInRoomTwo != null && enemyTwoInRoomTwo != null)
        {
            enemyOneInRoomTwo.SetActive(true);
            enemyTwoInRoomTwo.SetActive(true);
            RoomOneEnterCounter++;
        }
        else if(room2.isInRoom2 == false)
        {
            enemyOneInRoomTwo.SetActive(false);
            enemyTwoInRoomTwo.SetActive(false);
            RoomOneEnterCounter = 0; 
        }
        if (room6.isInRoom6 == true && RoomSixEnterCounter < 1 && enemyOneInRoomSix != null)
        {
            enemyOneInRoomSix.SetActive(true);
            RoomSixEnterCounter++;
        }
        else if (room6.isInRoom6 == false)
        {
            enemyOneInRoomSix.SetActive(false);
            RoomSixEnterCounter = 0;
        }
        if (room12.isInRoom12 == true && Room12EnterCounter < 1 && enemyOneInRoom12 != null && enemyTwoInRoom12 != null && enemyThreeInRoom12 != null)
        {
            enemyOneInRoom12.SetActive(true);
            enemyTwoInRoom12.SetActive(true);
            enemyThreeInRoom12.SetActive(true);
            Room12EnterCounter++;
        }
        else if (room12.isInRoom12 == false)
        {
            enemyOneInRoom12.SetActive(false);
            enemyTwoInRoom12.SetActive(false);
            enemyThreeInRoom12.SetActive(false);
            Room12EnterCounter = 0;
        }
        if (room13.isInRoom13 == true && Room13EnterCounter < 1 && enemyOneInRoom13 != null && enemyTwoInRoom13 !=null)
        {
            enemyOneInRoom13.SetActive(true);
            enemyTwoInRoom13.SetActive(true);
            enemyThreeInRoom13.SetActive(true);
            Room13EnterCounter++;
        }
        else if (room13.isInRoom13 == false)
        {
            enemyOneInRoom13.SetActive(false);
            enemyTwoInRoom13.SetActive(false);
            enemyThreeInRoom13.SetActive(false);
            Room13EnterCounter = 0;
        }
        if (room16.isInRoom16 == true && Room16EnterCounter < 1 && enemyOneInRoom16 != null)
        {
            enemyOneInRoom16.SetActive(true);
            Room16EnterCounter++;
        }
        else if (room16.isInRoom16 == false)
        {
            enemyOneInRoom16.SetActive(false);
            Room16EnterCounter = 0;
        }
        if (room22.isInRoom22 == true && Room22EnterCounter < 1 && enemyOneInRoom22 != null)
        {
            enemyOneInRoom22.SetActive(true);
            enemyTwoInRoom22.SetActive(true);
            enemyThreeInRoom22.SetActive(true);
            Room22EnterCounter++;
        }
        else if (room22.isInRoom22 == false)
        {
            enemyOneInRoom22.SetActive(false);
            enemyTwoInRoom22.SetActive(false);
            enemyThreeInRoom22.SetActive(false);
            Room22EnterCounter = 0;
        }
    }

}
