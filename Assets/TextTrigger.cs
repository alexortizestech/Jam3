using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public bool isActive;
    public float firstLimit;
    public float currenttime2;
    public GameObject Dialogue1, Dialogue2;
    public float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            currentTime += Time.deltaTime;
        }
        currenttime2 = 1*Time.deltaTime;
        if (currentTime >= firstLimit)
        {
            Dialogue1.SetActive(true);
        }

        if (currentTime >= firstLimit+5)
        {
            Dialogue1.SetActive(false);
            Dialogue2.SetActive(true);
        }
        if (currentTime >= firstLimit+10)
        {
           
            Dialogue2.SetActive(false);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isActive = true;
           
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Dialogue1.SetActive(false);
            Dialogue2.SetActive(false);
        }

    }
}
