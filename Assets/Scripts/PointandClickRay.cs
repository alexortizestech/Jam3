using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointandClickRay : MonoBehaviour
{
    public Level01 lvl1;
    public Level02 lvl2;
    public Level03 lvl3;
    public Inventory Inventory;
    public float Length;
    public LayerMask Layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            
           RaycastHit Hit;
            Ray Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(Ray, out Hit, Length, Layer))
            {
                if (Hit.transform.gameObject.tag == "Collectable1")
                {
                    Destroy(Hit.transform.gameObject); 
                    Inventory.Object1 = true;
                }
                if (Hit.transform.gameObject.tag == "Collectable2")
                {
                    Destroy(Hit.transform.gameObject);
                    Inventory.Object2 = true;
                }
                if (Hit.transform.gameObject.tag == "Collectable3")
                {
                    Destroy(Hit.transform.gameObject);
                    Inventory.Object3 = true;
                }
                if (Hit.transform.gameObject.tag == "Collectable4")
                {
                    Destroy(Hit.transform.gameObject);
                    Inventory.Object4 = true;
                }
                if (Hit.transform.gameObject.tag == "Flowerpot")
                {
                    lvl1.FlowerpotMoved = true;
                }
                if (Hit.transform.gameObject.tag == "Flowerpot")
                {
                    lvl1.FlowerpotMoved = true;
                }
                if (Hit.transform.gameObject.tag == "Bucket")
                {
                    lvl1.BucketMoved = true;
                }
                if (Hit.transform.gameObject.tag == "FirstDoor")
                {
                    if (Inventory.Object1)
                    {
                        lvl1.DoorOpen();
                    }
                }
                if (Hit.transform.gameObject.tag == "Fridge")
                {
                    lvl2.Fridge = true;
                }
               
                if (Hit.transform.gameObject.tag == "Alacena")
                {
                    lvl2.Alacena = true;
                    
                }
               
                if (Hit.transform.gameObject.tag == "Vessel")
                {
                    lvl2.Vessel = true;
                }
                if (Hit.transform.gameObject.tag == "Water")
                {
                    lvl2.Water = true;
                }
                if (Hit.transform.gameObject.tag == "GardenDoor")
                {
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
                    lvl3.Drawer = true;
                }
                if (Hit.transform.gameObject.tag == "Wardrobe")
                {
                    lvl3.Wardrobe = true;
                }
                if (Hit.transform.gameObject.tag == "Box")
                {
                    lvl3.Box = true;
                }
                if (Hit.transform.gameObject.tag == "Lever")
                {
                    lvl3.Lever = true;
                }
                
                if (Hit.transform.gameObject.tag == "PlayersDoor")
                {
                    lvl3.PlayersDoor = true;
                }

                Debug.Log(Hit.collider.name);
            }
        }
    }
}
