using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Text;

public class MessageTrigger2 : MonoBehaviour {

	private bool inside = false;
	protected StreamReader reader = null;
	private bool fileNotRead = false;
	private string someText = "";
	private string text = "";
	private string number = "";
	protected string line = "";
	private bool keyDown = false; 
	private int i = 1; 


	void OnTriggerEnter(Collider c) {
		text = "Press e to interact";
		if(fileNotRead == false){
			fileNotRead = true;
		}
		inside = true;
	}
	
	void OnTriggerExit(Collider c){
		inside = false; 
		text = ""; 
	}

	// Update is called once per frame
	void Update () {

		if ( inside == true && Input.GetKeyDown ("e") && keyDown == false)
		{
			Debug.Log("Should definitely be inside and pressing e!");
			setText (); 
			keyDown = true;
		}
		else if(!Input.GetKeyDown ("e"))
		{
			keyDown = false; 
		}
	}

	void setText () {
		text = "";
		someText = "";
		reader = new StreamReader(@"angelConv.txt");

		Debug.Log ("setText() used!");
		line = reader.ReadLine ();
		number = i.ToString();

		if (i < 5) 
		{
			if( line == null )
			{
				text = "no file found";
			}

			Debug.Log("Gonna try to compare line vs number!");
			while ( (String.Compare (line, number)) != 0) {
				line = reader.ReadLine ();
			}

			i++; 
			number = i.ToString();
			line = reader.ReadLine ();

			while((String.Compare (line, number)) != 0){
				someText += line;  
				someText += "\n";
				line = reader.ReadLine ();
			}

			text = someText; 
		}

		else {
			text = "Go away!"; 
		}

		Debug.Log ("End of setText()");
	}

	void OnGUI(){
		if (inside == true)
		{
			GUI.Box(new Rect(900, 500, 250, 150), text);
		}
	}
}