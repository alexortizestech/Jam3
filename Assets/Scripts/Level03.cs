using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level03 : MonoBehaviour
{
    public GameObject Draw;
    public WinLose WinLose;
    public Inventory Inventory;
    public bool BrothersDoor, FathersDoor, BathroomDoor, Drawer, Wardrobe, Box, Lever,PlayersDoor;
    // Start is called before the first frame update
    void Start()
    {
        
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
                Wrong();
            }
        }

        if (Box)
        {
            //move box
        }
        if (Lever)
        {
            //move box with + velocity
        }

        if (PlayersDoor)
        {
            if (Box)
            {
                NextLevel();
            }

        }

        if (Wardrobe)
        {
            //hide
        }
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
