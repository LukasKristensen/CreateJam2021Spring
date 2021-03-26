using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


//Kode fra https://www.youtube.com/watch?v=CHV1ymlw-P8
public class PlayerController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Move character
                agent.SetDestination(hit.point);
            }
        }
        
    }
}
