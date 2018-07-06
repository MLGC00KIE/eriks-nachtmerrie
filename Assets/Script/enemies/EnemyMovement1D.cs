using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement1D : MonoBehaviour {

    public float speed = 1.5f;
	private Animator anim;
    // Update is called once per frame
    private void Update () {
	    transform.position += Vector3.left * speed * Time.deltaTime;
		anim = GetComponent<Animator> ();
    }
	public void KillEnemy()
	{
		anim.SetBool ("Deadtrigger", true);
		float duration = anim.GetCurrentAnimatorClipInfo (0).Length;
		Destroy(gameObject, 0.5f);
	}
}
