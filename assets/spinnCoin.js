@script RequireComponent(AudioSource)
#pragma strict

function Start () {

}	
	var spinVelosity = 30;
	var plock = false;
	
	//hela tiden
	function Update () {
		//roterar objektet		
		if (plock == false)
		{
			transform.Rotate(0,spinVelosity*Time.deltaTime,0);
		}
		else if (plock == true)
		{
			transform.Rotate(0,spinVelosity*5*Time.deltaTime,0);
			transform.position = Vector3(transform.position.x, transform.position.y + Time.deltaTime, transform.position.z);
		}
	}
	
	//när man går in i objektet
	function OnTriggerEnter(other : Collider) {
			//spelar upp ett ljud och roterar snabare
			audio.Play();
			spinVelosity = 100; // denna fungerar inte :(
			plock = true;
			
			//väntar 1 sekund innan objektet tas bort
			yield WaitForSeconds(1);	
			Destroy (gameObject);
	}