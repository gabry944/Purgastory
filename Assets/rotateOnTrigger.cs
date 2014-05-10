using UnityEngine;
using System.Collections;
public class rotateOnTrigger : MonoBehaviour {

	public float AngleX = 0.0f;
	public float AngleY = 90.0f; 
	public float AngleZ = 0.0f; 
	
	float targetValue = 0.0f; 
	float currentValue = 0.0f; 
	float easing = 0.015f; 
	
	public GameObject Target;
	// Use this for initialization
	void Start () {

		
	}
	// Update is called once per frame
	void Update () {

		currentValue = currentValue + (targetValue - currentValue) * easing; 

		Target.transform.rotation = Quaternion.identity; 
		Target.transform.Rotate (0, currentValue, 0); 
	}

	void OnTriggerEnter (Collider other) {
		targetValue = AngleY; 
		currentValue = 0; 
		}

}
