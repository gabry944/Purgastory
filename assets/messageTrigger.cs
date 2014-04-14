using UnityEngine;
using System.Collections;

public class messageTrigger : MonoBehaviour {

	public GUIText angelInteract;
	private bool inside = false;

	void OnTriggerEnter(Collider c){
		angelInteract.text = "Press e to interact";
		inside = true;
	}

	void OnTriggerExit(Collider c){
		inside = false;
		angelInteract.text = "";
	}
}