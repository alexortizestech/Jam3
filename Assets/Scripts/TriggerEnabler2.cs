using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnabler2 : MonoBehaviour
{
    public Level02 LVL2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LVL2.enabled = true;

        }
    }

    public void OnTriggerExit(Collider other)
    {
        LVL2.enabled = false;
    }
}
