using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBP : MonoBehaviour
{
    public SpriteRenderer enemy;
    public float speed = 1.19f;
    private Vector3 pointA;
    private Vector3 pointB;
	private Animator anim;
    // start
    private void Start()
    {
        enemy = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator> ();

        // punten waar tussen de enemy heen en weer gaat
		pointA = new Vector3((float)7.57, (float)-0.703, 0);
		pointB = new Vector3((float)7.57, (float)0.309, 0);
    }

    // update
    private void Update()
    {
        //PingPong tussen 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
	public void KillEnemy()
	{
		anim.SetTrigger ("DeadTrigger");
		float duration = anim.GetCurrentAnimatorClipInfo (0).Length;
		print (duration);
		Destroy (gameObject, duration /2f);
	}

}

