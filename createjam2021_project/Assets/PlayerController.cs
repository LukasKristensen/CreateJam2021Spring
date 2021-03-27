using UnityEngine;
using UnityEngine.AI;


//Kode fra https://www.youtube.com/watch?v=CHV1ymlw-P8
public class PlayerController : MonoBehaviour
{
	public Camera cam;
	public NavMeshAgent agent;
	public Transform target;
	public Transform hands;
	public Transform drink;
	public Transform food;
	public float dist;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(1))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				// Move character
				agent.SetDestination(hit.point);
			}
		}
		if (Input.GetMouseButton(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				// Move character
				dist = Vector3.Distance(hit.transform.position, transform.position);
				if (dist < 1)
				{
					print("Hit something" + hit.transform.name);
					target = hit.transform;
					if (target.name == "FoodStation")
					{
						food.gameObject.SetActive(true);
						drink.gameObject.SetActive(false);
					}
					else if (target.name == "DrinkStation")
					{
						drink.gameObject.SetActive(true);
						food.gameObject.SetActive(false);
					}
				}
			}
		}

	}
}
