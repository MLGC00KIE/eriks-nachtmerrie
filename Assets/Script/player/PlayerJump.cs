using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerJump : MonoBehaviour {

	public Vector3 jump;
	public float jumpForce = 1.0f;
	public bool isGrounded;
    
	private Rigidbody rb;
	[SerializeField]
	private bool flip;

    private void Start(){
		rb = GetComponent<Rigidbody>();
		jump = new Vector3(0.2f, 1.8f, 0.0f);
	}

    private void OnCollisionStay()
	{
		isGrounded = true;
	}

    private void Update(){
		if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
			Vector3 actualJump = new Vector3(jump.x * (flip? -1 : 1), jump.y, jump.z);
			rb.AddForce(actualJump * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}
		if(Input.GetKeyDown(KeyCode.A) && isGrounded){
			flip = true;
	}
		if(Input.GetKeyDown(KeyCode.D) && isGrounded){
			flip = false;
		}
}
}