using UnityEngine;
using System.Collections;

public class personTrigger : MonoBehaviour {

	private bool close = false;
	private string message = "Press E 2";

	void SetTheGUI(){
		close = true;
	}

	void UnSetGUI(){
		close = false;
	}

	void OnGUI(){
		if (close)
			GUI.Label (new Rect(25, 25, 100, 30), message);
	}

}
