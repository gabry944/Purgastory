using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {


	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		Application.LoadLevel("startplatta");
	}
}
