using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public Text hp;
	public Text time;
	public Pilot pilot;
	public PowerGuy powerGuy;
	public Image progressBar;
	public RectTransform rocket;
	public float acttime = 0;
	public float acthp = 100;
	public scrollingbackground sb;
	public float progress = 0;
	public float speed = 1 ;
	public int numSecsNeeded = 10;
	public GameObject victoryScreen;
	public GameObject deathScreen;
	public bool pause;
	Vector3 left = new Vector3(-0.25f, 0f, 0f);
	// Start is called before the first frame update
	void Start()
	{
		
		Time.timeScale = 1;
		rocket.Translate(left);
	}

    // Update is called once per frame
    void Update()
    {
		rocket.Translate(left);
		speed = 1;
		if (pilot.sleeping)
		{
			//acthp = acthp - Time.deltaTime;
			sb.scrollSpeed = sb.scrollSpeed - 0.25f;
			speed = speed - 0.5f;
		}
		if (powerGuy.hungry) {
			//acthp = acthp - Time.deltaTime;
			sb.scrollSpeed = sb.scrollSpeed - 0.25f;
			speed = speed - 0.5f; }

		progressBar.fillAmount = progress;
		
		sb.scrollSpeed = 0.5f;
		acttime = acttime + Time.deltaTime;
		progress = progress + (Time.deltaTime/numSecsNeeded)*speed;
		//time.text = "Time : " + acttime;
		
		hp.text = "Health: " + acthp;
		if (progress>=1) {
			WIN();
		}
	}

	
	public void DIE() {
		Time.timeScale = 0;
		deathScreen.SetActive(true);
	}
	public void WIN() {
		Time.timeScale = 0;
		victoryScreen.SetActive(true);
		time.text = "Time : " + acttime;
	}


	public void Return() {
		SceneManager.LoadScene(0);
	}
}
