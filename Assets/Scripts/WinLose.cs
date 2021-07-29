using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public GameObject Player;
    public bool isDone;
    public CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lose()
    {
        cc.enabled = false;
    }

    public void Win()
    {
        Player.GetComponent<Animator>().Play("Climb Bed");
        Time.timeScale = 0;
        isDone = true;
    }
}
