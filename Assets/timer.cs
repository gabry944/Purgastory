using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

	float timertime = 45; 
	bool timeup = false;

	// Update is called once per frame
	void Update () {
		if (timertime > 0)
		{
			timertime -= Time.deltaTime;
		}
		else if (timeup == false && timertime == 0)
		{
			OnGUI();
			timeup = true;
		}
	}

	void OnGUI()
	{
		GUI.Box(new Rect(10, 10, 50, 20), "" + timertime.ToString("0"));
		
		if (timertime < 1)
		{
			GUI.Box(new Rect(500, 300, 350, 150), "\n \n Time is up! \n\n\n You are way too greedy \n to succeed.  " );
			if (GUI.Button(new Rect(640, 420, 80, 20), "Oh, crap! ") ) 
			{
				Application.LoadLevel("bajs");
			}
		}
	}
}
