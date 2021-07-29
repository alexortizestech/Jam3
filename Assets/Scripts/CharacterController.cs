using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterController : MonoBehaviour
{
  
    public GameObject Player;
    public bool Catched;
    public float current;
    NavMeshAgent agent;
    public float destiny;
    public float limit;
    // Start is called before the first frame update
    void Start()
    {
       
        Catched = false;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        current = transform.position.x;
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
            destiny = hit.point.x;
            limit = destiny - current;
            
            if (limit>=5||limit<=-5)
            {
                Player.GetComponent<Animator>().Play("Run");
                Catched = true;
                // Time.timeScale = 0;
            }
            else
            {
                Player.GetComponent<Animator>().Play("Walk");
            }
        }
        
    }

   
}
