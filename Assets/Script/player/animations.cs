using UnityEngine;
using System.Collections;

public class animations : MonoBehaviour {

	public Animator anim;
	public Rigidbody rbody;


	private float inputH;
	private float inputV;
	private bool run;

    // Use this for initialization
    private void Start () 
	{
		anim = GetComponent<Animator>();
		rbody = GetComponent<Rigidbody>();
		run = false;
	}

    // Update is called once per frame
    private void Update ()
	{
		

		if (Input.GetKey ("space")) {
			anim.Play ("Jump");

			anim.SetBool ("Jumpbool", true);
		}
		else if (Input.GetKey ("d")) {
			anim.Play ("Walk");
		}
		else if (Input.GetKey ("f")) {
			anim.Play ("shoot");
		}
		else if (Input.GetKey ("a")) {
			anim.Play ("walkback");
		}
		else {
			anim.Play ("Idle");
	}
	}
}