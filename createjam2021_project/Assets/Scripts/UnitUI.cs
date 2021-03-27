using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitUI : MonoBehaviour
{
	public Canvas canvas;
	public Image bar;
	public int patience = 1;
	public float happiness = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

		if (patience == 3) {
			if (happiness != 1)
			{
				happiness = happiness + (Time.deltaTime/5);
				if (happiness > 1)
				{
					happiness = 1;
				}
			}
			bar.color = Color.green;
			bar.fillAmount = happiness;
			

		} else if (patience == 2) { bar.color = Color.yellow; }
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
