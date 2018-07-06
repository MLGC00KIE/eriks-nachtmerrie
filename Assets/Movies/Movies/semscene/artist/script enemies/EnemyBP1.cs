using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBP1 : MonoBehaviour
{
    public SpriteRenderer enemy;
    public float speed = 1.19f;
    private Vector3 pointA;
    private Vector3 pointB;
    private Animator anim;


    // start
    private void Start()
    {
        anim = GetComponent<Animator>();
        enemy = GetComponent<SpriteRenderer>();

        // punten waar tussen de enemy heen en weer gaat
        pointA = new Vector3((float)2.8, (float)-0.46, 0);
        pointB = new Vector3((float)1.44, (float)-0.46, 0);
    }

    // update
    private void Update()
    {
        //PingPong tussen 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);

        if (transform.position.x == (float)1.50)
        {
            enemy.flipX = true;
        }
        else if (transform.position.x == (float)2.8)
        {
            enemy.flipX = false;
        }


    }

    public void KillEnemy()
    {
        anim.SetTrigger("Deadtrigger");
        float duration = anim.GetCurrentAnimatorClipInfo(0).Length;
        Destroy(gameObject, 0.5f);
    }
}


