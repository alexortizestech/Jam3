using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01 : MonoBehaviour
{
    public AudioSource Basura;
   public bool opendoor;
    bool mybucketmove;
    bool rightdone;
    bool myfunctionDone;
    public GameObject Door;
    public GameObject Buck;
    public GameObject flowerpot;
    public Inventory Inventory;
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

        if (BucketMoved)
        {
            if (!mybucketmove)
            {
                MoveBucket();
            }
           
        }
        if (FlowerpotMoved)
        {
            if (!BucketMoved)
            {
                //flowerpot.transform.position = Vector3.Lerp(flowerpot.transform.position, new Vector3(0f, flowerpot.transform.position.y, flowerpot.transform.position.z), 0.1f * Time.deltaTime);
                if (!myfunctionDone)
                {
                    Failed();
                }
                
            }
            if (BucketMoved)
            {
                if (!rightdone)
                {
                    Right();
                }
              
            }
        }



        
    }


    public void Failed()
    {
        flowerpot.transform.Translate(0.2f, 0.0f, 0.0f);
        Basura.Play();
        WinLose.Lose();
        myfunctionDone = true;
    }

    public void MoveBucket()
    {
        Buck.transform.Translate(0.0f,0.0f,2f);
        mybucketmove = true;
    }

    public void Right()
    {
        flowerpot.transform.Translate(1.0f, 0.0f, 0.0f);
        rightdone = true;
    }

    
    public void DoorOpen()
    {
        if (!opendoor)
        {
            Door.transform.Rotate(0, -90, 0);
            opendoor = true;
        }
           
        
    }
}
