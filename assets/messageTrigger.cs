using UnityEngine;
using System.Collections;

public class messageTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		SendMessageUpwards ("Press E");
	}

	void OnTriggerExit(Collider c){
		SendMessageUpwards("UnSetGUI");
	}
}