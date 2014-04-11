using UnityEngine;
using System.Collections;

public class maintest : MonoBehaviour {
	void OnGUI(){
		float buttonWidth = 200;
		float buttonHeight = 30;

		if (GUI.Button (new Rect (Screen.width / 2 - buttonWidth / 2, Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight), "Ladda testscen!")){
			Application.LoadLevel("startplatta");
		}
	}
}
