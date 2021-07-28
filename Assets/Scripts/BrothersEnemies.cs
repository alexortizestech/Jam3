using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrothersEnemies : MonoBehaviour
{
    public WinLose WinLose;
    public bool isPlayer;
    public bool isEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayer)
        {
            WinLose.Lose();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayer = true;
        }

    }
}
