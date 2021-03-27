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
	public GameManager gm;
	public GameObject awake;
	public GameObject tired;
	public GameObject sleep;

	// Start is called before the first frame update
	void Start()
    {
		m_Material = GetComponent<Renderer>().material;
		gm = FindObjectOfType<GameManager>();
	}

    // Update is called once per frame
    void Update()
    {
		distanceToPlayer = Vector3.Distance(playerTransform.position, transform.position);
		timegone = timegone + Time.deltaTime;
		if (sleeping)
		{
			if (distanceToPlayer < 1 && pc.target == this.transform) { 
				sleeping = false;
				timegone = 0;
				sleep.SetActive(false);
				awake.SetActive(true);
			}
		}
		else {
			if (timegone > 13) {
				sleeping = true;
				sleep.SetActive(true);
				tired.SetActive(false);
			} else if (timegone > 6) {
				awake.SetActive(false);
				tired.SetActive(true);
			}
		}
    }
}
