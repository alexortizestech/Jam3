using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSteps : MonoBehaviour
{
    public WinLose WinLose;
    public CharacterController CC;
    public GameObject Player;
    public float currentposition;
    public AudioSource HardSteps;
    public float limit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentposition = Player.transform.position.x;
        limit = CC.destiny + 10.0f;
        if(CC.destiny > currentposition)
        {
            HardSteps.Play();
            WinLose.Lose();
        }
    }
}
