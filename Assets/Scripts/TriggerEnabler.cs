using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnabler : MonoBehaviour
{
    public Level01 LVL1;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LVL1.enabled = true;
           
        }
    }

    public void OnTriggerExit(Collider other)
    {
        LVL1.enabled = false;
    }
}
