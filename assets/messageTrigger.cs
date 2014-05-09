using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Text;

public class messageTrigger : MonoBehaviour {

	private bool inside = false;
	protected StreamReader reader = null;
	protected string line = "";
	private bool fileNotRead = true;
	private string text = "";
	private int EOF = 1;

	void OnTriggerEnter(Collider c){
		text = "Press e to interact";
		OnGUI ();

		if(fileNotRead == true){
			loadFile();
		}

		inside = true;
	}

	void loadFile(){
		switch(EOF){
		case 1:
			reader = new StreamReader(@"angelConv.txt");
			fileNotRead = false;
			break;
		case 2:
			reader = new StreamReader(@"labWin.txt");
			fileNotRead = false;
			break;
		}
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
			else{
				fileNotRead = true;
				EOF++;
				loadFile ();
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