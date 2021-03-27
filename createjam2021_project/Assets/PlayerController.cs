using UnityEngine;
using UnityEngine.AI;


//Kode fra https://www.youtube.com/watch?v=CHV1ymlw-P8
public class PlayerController : MonoBehaviour
{
	public Camera cam;
	public NavMeshAgent agent;
	public Transform target = null;
	public Transform hands;
	public Transform drink;
	public Transform food;
	public float dist;
	public GameManager gm;


	void Start()
	{
		gm = FindObjectOfType<GameManager>();
	}
	// Update is called once per frame
	void Update()
	{
		//if (Input.GetMouseButton(1))
		//{
		//Ray ray = cam.ScreenPointToRay(Input.mousePosition);
		//RaycastHit hit;

		//if (Physics.Raycast(ray, out hit))
		//{
		// Move character
		//agent.SetDestination(hit.point);
		//}
		//}

			if (Input.GetMouseButton(1))
			{
				Ray ray = cam.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;

				if (Physics.Raycast(ray, out hit))
				{
					// Move character

					//if (dist < 1)
					//{
					target = hit.transform;
					agent.SetDestination(hit.point);
					//}
				}
			}
			if (target != null)
			{

				dist = Vector3.Distance(target.transform.position, transform.position);

				if (target.name == "FoodStation" && dist < 2)
				{
					food.gameObject.SetActive(true);
					drink.gameObject.SetActive(false);
				}
				else if (target.name == "DrinkStation" && dist < 2)
				{
					drink.gameObject.SetActive(true);
					food.gameObject.SetActive(false);
				}
			}
		}
	}
