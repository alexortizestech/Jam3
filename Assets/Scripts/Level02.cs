using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level02 : MonoBehaviour
{
    public GameObject target;
    bool VesselMoved;
    public WinLose WinLose;
    public Inventory Inventory;
    public GameObject Ves;
    public GameObject Mueble;
    public GameObject Hamster;
    public bool Fridge, Alacena, Vessel, Water, GardenDoor, firstStairs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Fridge)
        {
            Wrong();
        }

        if (Water)
        {
            Wrong();
        }

        if (Alacena)
        {
            if (Inventory.Object2)
            {
                Mueble.SetActive(false);
            }
        }

        if (Vessel)
        {
            MoveVessel();
        }
        if (GardenDoor)
        {
            if (Inventory.Object3)
            {
                Hamster.transform.position = target.transform.position;
            }
        }
       
        if (firstStairs)
        {
            if (!Hamster.activeSelf)
            {
                NextLevel2();
            }
            if (Hamster.activeSelf)
            {
                Wrong();
            }
        }
    }

    public void Wrong()
    {
        WinLose.Lose();
    }

    public void MoveVessel()
    {
        if (!VesselMoved)
        {
            Ves.transform.Translate(0.5f, 0.0f, 0.0f);
            VesselMoved = true;

        }
       
    }
    public void NextLevel2()
    {

    }
}
