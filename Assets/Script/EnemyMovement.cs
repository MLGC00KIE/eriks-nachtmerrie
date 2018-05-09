using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public bool isPlatformEnemy;

    public LayerMask enemyMask;
    Rigidbody Body;
    Transform Trans;
    float Width;
    public float speed = 1;

	// Use this for initialization
	void Start () {
        Trans = this.transform;
        Body = this.GetComponent<Rigidbody>();
        Width = this.GetComponent<SpriteRenderer>().bounds.extents.x;
	}

    // Update is called once per frame
    void FixedUpdate()
    {

        if (isPlatformEnemy)
        {
            Vector3 lineCastPos = Trans.position - Trans.right * Width;
            Debug.DrawLine(lineCastPos, lineCastPos + Vector3.down);
            bool isGrounded = Physics.Linecast(lineCastPos, lineCastPos + Vector3.down, enemyMask);

            if (!isGrounded)
            {
                Vector3 currentRot = Trans.eulerAngles;
                currentRot.y += 180;
                Trans.eulerAngles = currentRot;
            }

            Vector3 velo = Body.velocity;
            velo.x = -Trans.right.x * speed;
            Body.velocity = velo;
        }

        else if (!isPlatformEnemy)
        {
            Vector3 velo = Body.velocity;
            velo.x = -Trans.right.x * speed;
            Body.velocity = velo;
        }


}

  
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("AIWALLS") && !isPlatformEnemy)
        {
            Vector3 currentRot = Trans.eulerAngles;
            currentRot.y += 180;
            Trans.eulerAngles = currentRot;
        }
    }

}
