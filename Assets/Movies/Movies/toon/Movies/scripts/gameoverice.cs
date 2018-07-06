using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverice : MonoBehaviour {
	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("gameover2");
		}
	}
}