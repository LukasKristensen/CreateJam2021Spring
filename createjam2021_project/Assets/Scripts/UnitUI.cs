using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitUI : MonoBehaviour
{
	public Canvas canvas;
	public Image bar;
	public Image wish;

	public GameManager gm;
	public int patience = 3;
	public float happiness = 1;
	// Start is called before the first frame update
	void Start()
	{
		gm = FindObjectOfType<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{
			if (happiness == 0)
			{
				gm.DIE();
			}
			if (patience == 3)
			{
				if (happiness != 1)
				{
					happiness = happiness + (Time.deltaTime / 5);
					if (happiness > 1)
					{
						happiness = 1;
					}
				}
				bar.color = Color.green;
				bar.fillAmount = happiness;
				wish.gameObject.SetActive(false);

			}
			else if (patience == 2)
			{
				bar.color = Color.yellow;
				wish.gameObject.SetActive(true);
			}
			else
			{
				bar.color = Color.red;
				if (happiness != 0)
				{
					happiness = happiness - (Time.deltaTime / 5);
					if (happiness < 0)
					{
						happiness = 0;
					}
				}
				bar.fillAmount = happiness;
			}

			canvas.transform.LookAt(Camera.main.transform);

		}
	}
