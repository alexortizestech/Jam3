using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHamster : MonoBehaviour
{
    public float step;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //step = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.Normalize(target.position - transform.position) * step);
    }
}
