using UnityEngine;
using System.Collections;


public class coinSpinn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	bool plock = false;
	float px, py, pz;
	Vector3 kordinarer = new Vector3(0,0,0);

	// Update is called once per frame
	void Update () {
		if (plock == false)
		{
			//roterar myntet
			transform.Rotate(0,30*Time.deltaTime,0);
		}
		else if (plock == true)
		{
			//roterar myntet snabbare
			transform.Rotate(0,180*Time.deltaTime,0);

			//tar reda på vilka kordinater myntet ska ha för att sväva uppåt
			px = transform.position.x;
			py = transform.position.y + Time.deltaTime;
			pz = transform.position.z;

			transform.position = new Vector3(px,py,pz);
		}	
	}
	//om myntet plockas upp
	IEnumerator  OnTriggerEnter(Collider other) {
		//spelar upp ett ljud och säger åt uppdatfunktionen att myntet är plockat
		audio.Play();
		plock = true;

		//adderar antalet plockade mynt till sliderskriptet
		slider.coins += 1;
		
		//väntar 1 sekund innan objektet tas bort
		yield return new WaitForSeconds(1);	
		Destroy (gameObject);
	}
}















