using UnityEngine;
using System.Collections;

public class slider : MonoBehaviour {


	static public int coins = 0;
	static public bool lvlFinished = false;
	public GUISkin skin;
	private float sliderValue = 1.0f;
	static public bool gameStarted = false;

	void OnGUI(){
		if(gameStarted == true)
			updateScore ();

		GUI.skin = skin;
		sliderValue = GUI.VerticalSlider(new Rect(Screen.width - 20, 10, 0, 100), coins, 2.0f, 0.0f);	
	}


	void updateScore(){
		if (lvlFinished == true)
			sliderValue += 1;
		else
			sliderValue -= 1;
	}
}
