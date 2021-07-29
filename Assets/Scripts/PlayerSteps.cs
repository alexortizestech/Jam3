using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSteps : MonoBehaviour
{
    public GameObject FatherDialogue1, FatherDialogue2;
    public float currentTime;
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
            
            currentTime += Time.deltaTime;
            FatherDialogue1.SetActive(true);
            if (currentTime > 5)
            {
                FatherDialogue1.SetActive(false);
                FatherDialogue2.SetActive(true);
            }
            HardSteps.Play();
            WinLose.Lose();

        }
    }
}
