using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointandClickRay : MonoBehaviour
{
    public Level01 lvl1;
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
                    Inventory.Object1 = true;
                }
                if (Hit.transform.gameObject.tag == "Collectable2")
                {
                    Inventory.Object2 = true;
                }
                if (Hit.transform.gameObject.tag == "Collectable3")
                {
                    Inventory.Object3 = true;
                }
                if (Hit.transform.gameObject.tag == "Collectable4")
                {
                    Inventory.Object4 = true;
                }
                if (Hit.transform.gameObject.tag == "Flowerpot")
                {
                    lvl1.FlowerpotMoved = true;
                }
                Debug.Log(Hit.collider.name);
            }
        }
    }
}
