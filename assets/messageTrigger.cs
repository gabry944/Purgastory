using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Text;

public class messageTrigger : MonoBehaviour {

	private bool inside = false;
	protected StreamReader reader = null;
	protected string line = "";
	private bool fileNotRead = false;
	private string text = "";


	void OnTriggerEnter(Collider c){
		text = "Press e to interact";
		OnGUI ();

		if(fileNotRead == false){
			reader = new StreamReader(@"angelConv.txt");
			fileNotRead = true;
		}
		inside = true;
	}

	void OnTriggerExit(Collider c){
		inside = false;
		text = "";
	}

	void Update(){

		if (inside == true && Input.GetKeyDown("e")){
			line = reader.ReadLine();
			if(line != null){
				text = line;
			}
			OnGUI ();
		}
	}

	void OnGUI(){
		if (inside == true)
		{
			GUI.Box(new Rect(900, 500, 250, 150), text);
		}
	}
}