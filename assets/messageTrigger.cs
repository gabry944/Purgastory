using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Text;

public class messageTrigger : MonoBehaviour {

	public GUIText angelInteract;
	private bool inside = false;
	protected FileInfo angelConv = null;
	protected StreamReader theReader = null;
	protected string line = "";
	private bool readingOK = false;

	void OnTriggerEnter(Collider c){
		angelInteract.text = "Press e to interact";
		inside = true;
	}

	void OnTriggerExit(Collider c){
		inside = false;
		angelInteract.text = "";
	}

	void start(){
		try{
			StreamReader theReader = new StreamReader("test.txt", Encoding.Default);
			readingOK = true;
		}
		catch(Exception e){
			Console.WriteLine("{0}\n", e.Message);
			readingOK = false;
		}
	}

	void Update(){
		if ( readingOK == true && inside == true) {
			if(Input.GetKey("e")){
				Console.WriteLine("pressed e");
				using(theReader){
					line = theReader.ReadLine();
					if(line != null){
						angelInteract.text = line;
					}
				}
			}	
		}

		else if (readingOK == false) {
			angelInteract.text = "file not read";
		}
	}
}