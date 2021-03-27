using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Text hp;
	public Text time;
	public Pilot pilot;
	public PowerGuy powerGuy;
	public float acttime = 0;
	public float acthp = 100;
	public scrollingbackground sb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		sb.scrollSpeed = 0.5f;
		acttime = acttime + Time.deltaTime;
		time.text = "Time : " + acttime;
		if (pilot.sleeping) { acthp = acthp - Time.deltaTime;
			sb.scrollSpeed = sb.scrollSpeed - 0.25f;
		}
		if (powerGuy.hungry) { acthp = acthp - Time.deltaTime; sb.scrollSpeed = sb.scrollSpeed - 0.25f; }
		hp.text = "Health: " + acthp;
	}
}
