using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject icon1, icon2, icon3, icon4;
    
    public bool Object1, Object2, Object3, Object4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Object1)
        {
            AddObject1();
        }
        if (Object2)
        {
            AddObject2();
        }
        if (Object3)
        {
            AddObject3();
        }
        if (Object4)
        {
            AddObject4();
        }
    }

    public void AddObject1()
    {
        icon1.SetActive(true);
    }
    public void AddObject2()
    {
        icon2.SetActive(true);
    }
    public void AddObject3()
    {
        icon3.SetActive(true);
    }
    public void AddObject4()
    {
        icon4.SetActive(true);
    }
}
