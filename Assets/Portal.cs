using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello, world, miqqo speaking!");
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == 3rdPersonController )
		{
			DontDestroyOnLoad(other.gameObject);
			Application.LoadLevel("Next Level");
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
