using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Text;

public class messageTrigger : MonoBehaviour {

	public GUIText angelInteract;
	private bool inside = false;
	protected FileInfo angelConv = null;
	protected StreamReader reader = null;
	protected string line = "";
	private bool fileNotRead = false;


	void OnTriggerEnter(Collider c){
		angelInteract.text = "Press e to interact";

		if(fileNotRead == false){
			reader = new StreamReader(@"angelConv.txt");
			fileNotRead = true;
		}
		inside = true;
	}

	void OnTriggerExit(Collider c){
		inside = false;
		angelInteract.text = "";
	}

	void Update(){

		if (inside == true && Input.GetKeyDown("e")){
			line = reader.ReadLine();
			if(line != null){
				angelInteract.text = line;
			}	
		}
	}
}