using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level03 : MonoBehaviour
{
    public GameObject ColliderWD;
    public bool Floor;
    public bool outer;
    public bool isHiding;
    public GameObject Player;
    public Transform Hide;
    public GameObject ArmarioAbierto,ArmarioCerrado;
    public GameObject MyDoor;
    public bool MyDoorMoved;
    public GameObject Brth;
    public bool movedDoor1;
    public TestBox TB;
    public float speed;
    public bool MovedBox;
    public GameObject ObjectBox;
    public GameObject Draw;
    public GameObject Draw2;
    public WinLose WinLose;
    public Inventory Inventory;
    public bool BrothersDoor, FathersDoor, BathroomDoor, Drawer, Wardrobe, Box, Lever,PlayersDoor;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
        outer = true;
        isHiding = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Drawer)
        {
            Draw.SetActive(false);
            Draw2.SetActive(true);
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

            if (!isHiding)
            {
                Hiding();
                

            }
        }

        if (Input.GetMouseButton(1))
        {
            if (!outer)
            {
                Out();
                Floor = false;
            }
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

    public void Hiding()
    {
        ArmarioAbierto.SetActive(true);
        ArmarioCerrado.SetActive(false);
        Player.transform.position = Hide.position;
        ColliderWD.SetActive(true);
        outer = false;
        Wardrobe = false;
        isHiding = true;
        


    }

    public void Out()
    {
       
        ArmarioAbierto.SetActive(false);
        ArmarioCerrado.SetActive(true);
        ColliderWD.SetActive(false);
        isHiding = false;
        
        outer = true;
    }
}
