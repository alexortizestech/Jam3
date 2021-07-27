using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointandClickRay : MonoBehaviour
{
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
                Debug.Log(Hit.collider.name);
            }
        }
    }
}
