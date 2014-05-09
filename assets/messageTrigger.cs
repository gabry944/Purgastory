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
	public string[] answerButtons;

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


			if(EOF == 2){
				if(GUI.Button(new Rect(1200,500,200,30), answerButtons[0])){

				}

				if(GUI.Button(new Rect(1200,535,200,30), answerButtons[1])){
					
				}
				if(GUI.Button(new Rect(1200,570,200,30), answerButtons[2])){
					
				}

			}
		}
	}
}