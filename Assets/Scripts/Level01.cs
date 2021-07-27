using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01 : MonoBehaviour
{
    public WinLose WinLose;
    public AudioSource Sound1;
    public bool BucketMoved;
    public bool FlowerpotMoved;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FlowerpotMoved)
        {
            if (!BucketMoved)
            {
                Failed();
            }
            if (BucketMoved)
            {
                Right();
            }
        }
    }


    public void Failed()
    {
        Sound1.Play();
        WinLose.Lose();
    }

    public void Right()
    {

    }
}
