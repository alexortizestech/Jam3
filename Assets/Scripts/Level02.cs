using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level02 : MonoBehaviour
{
    public GameObject AlacenaCerrado, AlacenaAbierto;
    public GameObject OpenFridge,ClosedFridge;
    public TestHamster TH;
    public Transform target2;
    public bool complete;
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
        target.transform.position = new Vector3(-6.8f, 1.2f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Fridge)
        {
            ClosedFridge.SetActive(false);
            OpenFridge.SetActive(true);
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
                AlacenaCerrado.SetActive(false);
                AlacenaAbierto.SetActive(true);
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
                //transform.position = target.transform.position,1.0f*Time.deltaTime;
                // Hamster.transform.position=Vector3.MoveTowards(transform.position, target2.position, 0.5f);
                // Hamster.transform.position = new Vector3(transform.position.x + target.transform.position.x, transform.position.y, transform.position.z);
                TH.enabled=true;
               complete = true;
            }
        }
       
        if (firstStairs)
        {
            if (complete)
            {
                NextLevel2();
            }
            if (!complete)
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
