using UnityEngine;
using UnityEngine.AI;


//Kode fra https://www.youtube.com/watch?v=CHV1ymlw-P8
public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsFloor, whatIsPlayer;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    // Update is called once per frame
    void Update()
    {
        float randomZ = Random.Range(-20, 20);
        float randomX = Random.Range(-20, 20);
        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        agent.SetDestination(walkPoint);
    }


}
