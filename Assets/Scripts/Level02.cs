using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level02 : MonoBehaviour
{
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
            Ves.SetActive(false);
        }
        if (GardenDoor)
        {
            if (Inventory.Object3)
            {
                Hamster.SetActive(false);
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
    public void NextLevel2()
    {

    }
}
