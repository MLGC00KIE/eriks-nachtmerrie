using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("a")) {
			transform.Translate (Vector3.left * Time.deltaTime);

		}
		if (Input.GetKey ("d")) {
			transform.Translate (Vector3.right * Time.deltaTime);

		}
			
	}
}






