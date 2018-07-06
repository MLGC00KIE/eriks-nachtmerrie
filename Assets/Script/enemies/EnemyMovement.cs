using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public SpriteRenderer enemy;
    public float speed;

	private Animator anim;
    // sprite renderer
    private void Start()
    {   
        enemy = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator> ();
    }

    private void Update()
	{
		// player tracker
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (current: transform.position, target: target.position, maxDistanceDelta: step);

		// flip van sprite false
		if (target.position.x < transform.position.x) {
			enemy.flipX = false;
		}

		// flip van sprite true
		if (target.position.x > transform.position.x) {
			enemy.flipX = true;
		}
	}

	public void KillEnemy()
	{
		anim.SetTrigger ("Deadtrigger");
		float duration = anim.GetCurrentAnimatorClipInfo (0).Length;
		Destroy (gameObject, 0.5f);
	}
			/*
		if (isDead)
		{
			Animator anim = GetComponent<Animator> ();
			anim

        }
	
	void OnCollision2D()
	{
		Animator anim = GetComponent<Animator> ();
		anim.SetBool ("isDead", true);
		isDead = true;
	}
	*/
}