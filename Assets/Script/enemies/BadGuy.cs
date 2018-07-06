using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour {
    private void OnTriggerEnter(Collider col)
	{
		HealthBar.Health -= 1f;
	}
}