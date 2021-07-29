using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBrothers : MonoBehaviour
{
    // Start is called before the first frame update
    float next_spawn_time;
    GameObject[] Brothers;
    public GameObject Brother1, Brother2, Brother3;
    public float timer;
    private void Start()
    {
        next_spawn_time = Time.time + 40.0f;
    }
    void Awake()
    {
    
    }


    // Update is called once per frame
    void Update()
    {
        /*   int count = (int)Random.Range(0, Brothers.Length);
           if (Time.time > next_spawn_time)
           {
               //do stuff here (like instantiate)
               GameObject clone = (GameObject)Instantiate(Brothers[count], transform.position, Quaternion.identity);
               Destroy(clone, 40.0f);

               //increment next_spawn_time
               next_spawn_time += 40.0f;
           }*/
        if (Time.timeSinceLevelLoad >= timer)
        {
            Brother1.SetActive(true);
        }

        if (Time.timeSinceLevelLoad >= timer*2)
        {
            Brother2.SetActive(true);
        }
        if (Time.timeSinceLevelLoad >= timer * 3)
        {
            Brother3.SetActive(true);
        }
    }
}
