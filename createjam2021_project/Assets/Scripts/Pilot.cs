using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilot : MonoBehaviour
{ 
	public Material m_Material;
	public float timegone = 0;
	public bool sleeping = false;
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
		if (sleeping)
		{
			if (distanceToPlayer < 1 && pc.target == this.transform) { 
			m_Material.color = Color.green;
			sleeping = false;
				timegone = 0;
			}
		}
		else {
			if (timegone>6) {
			
			m_Material.color = Color.red;
			sleeping = true;
			}
		}
    }
}
