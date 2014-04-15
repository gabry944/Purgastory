using UnityEngine;
using System.Collections;

public class slider : MonoBehaviour {


	static public int coins = 0;

	public GUISkin skin;
	private float sliderValue = 1.0f;

	void OnGUI(){

		GUI.skin = skin;
		sliderValue = GUI.VerticalSlider(new Rect(Screen.width - 20, 10, 0, 100), sliderValue, 2.0f, 0.0f);	
	}
}
