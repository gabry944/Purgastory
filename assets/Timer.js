#pragma strict

var timer : float = 10.0; 
var boxHeight : float = 800.0;  
var boxWidth : float = 800.0; 

function Update()
{
	timer -= Time.deltaTime;
	
	if (timer > 0)
	{
		//GUIText.text = "";
	}
	else
	{
		timer = 0; 
	}
}

function OnGUI()
{
	GUI.Box(new Rect(10, 10, 50, 20), "" + timer.ToString("0"));
	
	if (timer == 0)
	{
		//GUIText.text = "Time's up! \n You're too greedy ";
		GUI.Box(new Rect(500, 300, 350, 150), "\n \n Time is up! \n\n\n You are way too greedy \n to succeed.  " );
		//GUI.Box(new Rect(800, 400, boxWidth, boxHeight), "\n \n Time is up! \n\n\n You are way too greedy \n to succeed.  " );
		if (GUI.Button(new Rect(640, 420, 80, 20), "Oh, crap! ") ) 
		{
			Application.LoadLevel("startplatta");
		}
	}
}
