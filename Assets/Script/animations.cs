﻿using UnityEngine;
using System.Collections;

public class animations : MonoBehaviour {

	public Animator anim;
	public Rigidbody rbody;

	private float inputH;
	private float inputV;
	private bool run;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
		rbody = GetComponent<Rigidbody>();
		run = false;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey ("space")) {
			anim.Play ("Jump");
		}
		else if (Input.GetKey ("d")) {
			anim.Play ("Run");
		}
		else if (Input.GetKey ("j")) {
			anim.Play ("Melee");
		}
		else if (Input.GetKey ("k")) {
			anim.Play ("Shoot");
		}
		else if (Input.GetKey ("s")) {
			anim.Play ("Idle");
		}
		else {
			anim.Play ("Idle");
	}
	}
}