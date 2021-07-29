using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerImage : MonoBehaviour
{
    public GameObject OpenImage;
    // Start is called before the first frame update
    void Start()
    {
        OpenImage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= 5)
        {
            OpenImage.SetActive(false);
        }
    }
}
