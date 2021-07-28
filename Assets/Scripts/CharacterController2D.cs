using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    public Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            target = new Vector2(mouse.x, mouse.y);
        }

        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5f);
    }
}
