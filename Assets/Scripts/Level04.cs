using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level04 : MonoBehaviour
{
    
    public WinLose WinLose;
    public bool MyBed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MyBed)
        {
            WinLose.Win();
        }

        
    }

   
}
