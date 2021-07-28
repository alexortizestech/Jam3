using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    public WinLose WinLose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
        Fail();

        }
        
    }

    public void Fail()
    {
        //do whatever
        WinLose.Lose();
    }
}
