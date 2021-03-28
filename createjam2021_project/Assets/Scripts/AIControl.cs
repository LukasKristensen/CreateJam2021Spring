using UnityEngine;
using UnityEngine.AI;


//Kode fra https://www.youtube.com/watch?v=CHV1ymlw-P8
public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    public HotSpots HotS;
    public int timeWaited;
    int hotspotNumberHold;

    // Update is called once per frame
    void Update()
    {
        if (!walkPointSet) SearchHotspot();
        if (walkPointSet) timeWaited++;
        if (timeWaited > 2000)
        {
            walkPointSet = false;
            timeWaited = 0;
            HotS.hotspotsReady[hotspotNumberHold] = true;
        }
    }


    void SearchHotspot()
    {
        System.Random random = new System.Random();
        int randomNumber = random.Next(0, 6);

        if (HotS.hotspotsReady[randomNumber])
        {
            HotS.hotspotsReady[randomNumber] = false;
            walkPoint.x = HotS.coordinates[randomNumber, 0];
            walkPoint.y = HotS.coordinates[randomNumber, 1];
            walkPoint.z = HotS.coordinates[randomNumber, 2];
            agent.SetDestination(walkPoint);
            walkPointSet = true;
            hotspotNumberHold = randomNumber;
            return;
        }

        

        
    }

    void SearchWalkpoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        walkPointSet = true;
    }

    void Interacting()
    {

    }

    void NeedInteraction()
    {

    }
}
