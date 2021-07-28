using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentsCatch : MonoBehaviour
{
    public bool isDone;
    public AudioSource FathersSound;
    public WinLose WinLose;
    public GameObject Father;
    public GameObject Mother;
    public CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        isDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.limit > 5 || cc.limit<-5)
        {
            if (!isDone)
            {
                FathersSound.Play();
                Father.GetComponent<Animator>().Play("Alert");

                Mother.GetComponent<Animator>().Play("Awaken");
                WinLose.Lose();
                isDone = true;
            }
            
        }
    }
}
