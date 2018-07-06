using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileCollision : MonoBehaviour
{
    private GameObject bullets;
	private Animator anim;
    void awake()
    {
        bullets = GameObject.FindGameObjectWithTag("Enemy");
    }
    void OnTriggerEnter (Collider other)
	{
        
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<EnemyMovement> ().KillEnemy ();
			/* Destroy(other.gameObject);*/
		}
		if (other.gameObject.tag == "Enemy2") {
			other.gameObject.GetComponent<EnemyMovement1D> ().KillEnemy ();
			/* Destroy(other.gameObject);*/
		}
		if (other.gameObject.tag == "Enemy3") {
			other.gameObject.GetComponent<EnemyMovementBP> ().KillEnemy ();
			/* Destroy(other.gameObject);*/
		}
		if (other.gameObject.tag == "Enemy4") {
			other.gameObject.GetComponent<EnemyBP1> ().KillEnemy ();
			/* Destroy(other.gameObject);*/
		}
		if (other.gameObject.tag == "Untagged") {
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == "Enemy5") {
			other.gameObject.GetComponent<EnemyMovement1Dice> ().KillEnemy ();
		}
	}
	void Update()
	{
		Destroy(this.gameObject, 0.5f);
	}
}
		