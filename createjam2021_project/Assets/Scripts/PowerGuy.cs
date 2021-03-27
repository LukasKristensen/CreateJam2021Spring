using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerGuy : MonoBehaviour
{
	public Material m_Material;
	public float timegone = 0;
	public bool hungry = false;
	public Transform playerTransform;
	public float distanceToPlayer;
	public PlayerController pc;

	// Start is called before the first frame update
	void Start()
	{
		m_Material = GetComponent<Renderer>().material;

	}

	// Update is called once per frame
	void Update()
	{
		distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);
		timegone = timegone + Time.deltaTime;
		if (hungry)
		{
				if (distanceToPlayer < 1 && pc.target == this.transform && pc.food.gameObject.activeInHierarchy)
				{
					m_Material.color = Color.green;
					hungry = false;
					timegone = 0;
					pc.food.gameObject.SetActive(false);
				}
	
		}
		else
		{
			if (timegone > 7)
			{

				m_Material.color = Color.red;
				hungry = true;
			}
		}
	}
}
