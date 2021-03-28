using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drinker : MonoBehaviour
{
	public Material m_Material;
	public float timegone = 0;
	public bool thirsty = false;
	public Transform playerTransform;
	public float distanceToPlayer;
	public PlayerController pc;
	public UnitUI ui;
	public GameManager gm;
	public int impatience = 15;

	// Start is called before the first frame update
	void Start()
	{
		//  m_Material = GetComponent<Renderer>().material;
		ui = GetComponent<UnitUI>();
		pc = playerTransform.GetComponent<PlayerController>();

	}

	// Update is called once per frame
	void Update()
	{
		
			distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);
			timegone = timegone + Time.deltaTime;
			if (thirsty)
			{
				if (timegone > impatience)
				{
					ui.patience = 1;
				}
				if (distanceToPlayer < 1 && pc.target == this.transform && pc.drink.gameObject.activeInHierarchy)
				{
					// m_Material.color = Color.green;
					thirsty = false;
					timegone = 0;
					pc.drink.gameObject.SetActive(false);
					ui.patience = 3;

				}

			}
			else
			{
				if (timegone > 7)
				{
					ui.patience = 2;
					// m_Material.color = Color.red;
					thirsty = true;

				}
			}
		}
	} 
