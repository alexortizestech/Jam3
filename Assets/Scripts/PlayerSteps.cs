using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSteps : MonoBehaviour
{
    public WinLose WinLose;
    public CharacterController CC;
    public AudioSource HardSteps;
    public AudioSource SoftSteps;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!CC.Catched)
        {
            SoftSteps.Play();
        }
        if (CC.Catched)
        {
            HardSteps.Play();
            WinLose.Lose();

        }
    }
}
