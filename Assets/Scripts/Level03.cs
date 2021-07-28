using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level03 : MonoBehaviour
{
    public GameObject MyDoor;
    public bool MyDoorMoved;
    public GameObject Brth;
    public bool movedDoor1;
    public TestBox TB;
    public float speed;
    public bool MovedBox;
    public GameObject ObjectBox;
    public GameObject Draw;
    public WinLose WinLose;
    public Inventory Inventory;
    public bool BrothersDoor, FathersDoor, BathroomDoor, Drawer, Wardrobe, Box, Lever,PlayersDoor;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Drawer)
        {
            Draw.SetActive(false);
        }

        if (BrothersDoor)
        {
            if (Drawer)
            {
                if (!movedDoor1)
                {
                    Brth.transform.Rotate(0, -90, 0);
                    movedDoor1 = true;
                }
                Wrong();
            }
        }

        if (Box)
        {
            if (!MovedBox)
            {
                MoveBox();
            }
            
        }
        if (Lever)
        {
            TB.step = 0.01f;
        }

        if (PlayersDoor)
        {

            if (Box)
            {
                if (!MyDoorMoved)
                {
                NextLevel();
                    MyDoor.transform.Rotate(0, -90, 0);
                    MyDoorMoved = true;
                }
            }

        }

        if (Wardrobe)
        {
            //hide
        }
    }

    public void MoveBox()
    {
        TB.enabled = true;
        MovedBox = true;
    }
    public void Wrong()
    {
        WinLose.Lose();
    }

    public void NextLevel()
    {
        //go to next level
    }
}
