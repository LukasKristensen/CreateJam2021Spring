using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerGuy : MonoBehaviour
{
	public float timegone = 0;
	public bool hungry = false;
	public Transform playerTransform;
	public float distanceToPlayer;
	public PlayerController pc;
	public GameManager gm;
	public Animator animator;

	// Start is called before the first frame update
	void Start()
	{
		gm = FindObjectOfType<GameManager>();
		animator = GetComponent<Animator>();
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
					animator.SetBool("tired",false);
					hungry = false;
					timegone = 0;
					pc.food.gameObject.SetActive(false);
				}

			}
			else
			{
				if (timegone > 11)
				{
				animator.SetBool("tired", true);
				hungry = true;
				}
			}
		}
	}
