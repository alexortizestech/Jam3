﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointandClickRay : MonoBehaviour
{
    public AudioSource PickSound;
    public GameObject Player;
    public Level01 lvl1;
    public Level02 lvl2;
    public Level03 lvl3;
    public Inventory Inventory;
    public float Length;
    public LayerMask Layer;
    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<Animator>().Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        Player.GetComponent<Animator>().Play("Idle");
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            
           RaycastHit Hit;
            Ray Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(Ray, out Hit, Length, Layer))
            {
                if (Hit.transform.position.x > Player.transform.position.x)
                {
                    Player.transform.Rotate(0, 0, 0);
                }
                if (Hit.transform.position.x < Player.transform.position.x)
                {
                    Player.transform.Rotate(0, 180, 0);
                }
                if (Hit.transform.gameObject.tag == "Collectable1")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    Destroy(Hit.transform.gameObject); 
                    Inventory.Object1 = true;
                }
                if (Hit.transform.gameObject.tag == "Collectable2")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    Destroy(Hit.transform.gameObject);
                    Inventory.Object2 = true;
                }
                if (Hit.transform.gameObject.tag == "Collectable3")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    Destroy(Hit.transform.gameObject);
                    Inventory.Object3 = true;
                }
                if (Hit.transform.gameObject.tag == "Collectable4")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    Destroy(Hit.transform.gameObject);
                    Inventory.Object4 = true;
                }
                if (Hit.transform.gameObject.tag == "Flowerpot")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl1.FlowerpotMoved = true;
                }
                if (Hit.transform.gameObject.tag == "Flowerpot")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl1.FlowerpotMoved = true;
                }
                if (Hit.transform.gameObject.tag == "Bucket")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl1.BucketMoved = true;
                }
                if (Hit.transform.gameObject.tag == "FirstDoor")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    if (Inventory.Object1)
                    {
                        lvl1.DoorOpen();
                    }
                }
                if (Hit.transform.gameObject.tag == "Fridge")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl2.Fridge = true;
                }
               
                if (Hit.transform.gameObject.tag == "Alacena")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl2.Alacena = true;
                    
                }
               
                if (Hit.transform.gameObject.tag == "Vessel")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl2.Vessel = true;
                }
                if (Hit.transform.gameObject.tag == "Water")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl2.Water = true;
                }
                if (Hit.transform.gameObject.tag == "GardenDoor")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl2.GardenDoor = true;
                }
                if (Hit.transform.gameObject.tag == "firstStairs")
                {
                    lvl2.firstStairs = true;
                }
                if (Hit.transform.gameObject.tag == "BrothersDoor")
                {
                    lvl3.BrothersDoor = true;
                }
                if (Hit.transform.gameObject.tag == "FathersDoor")
                {
                    lvl3.FathersDoor = true;
                }
                if (Hit.transform.gameObject.tag == "Drawer")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl3.Drawer = true;
                }
                if (Hit.transform.gameObject.tag == "Wardrobe")
                {
                    Player.GetComponent<Animator>().Play("Hide");
                    lvl3.Wardrobe = true;
                }
                if (Hit.transform.gameObject.tag == "Box")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl3.Box = true;
                }
                if (Hit.transform.gameObject.tag == "Lever")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl3.Lever = true;
                    Destroy(Hit.transform.gameObject);
                }
                
                if (Hit.transform.gameObject.tag == "PlayersDoor")
                {
                    Player.GetComponent<Animator>().Play("Take");
                    lvl3.PlayersDoor = true;
                }
                if (Hit.transform.gameObject.tag == "Floor")
                {
                    lvl3.Floor = true;
                }
                    Debug.Log(Hit.collider.name);
            }
        }
    }
}
