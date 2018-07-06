using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover2 : MonoBehaviour {
	private void OnCollisionEnter(Collision collision)

	{
		if (collision.gameObject.tag == "Player")
		{

			SceneManager.LoadScene ("gameover2");

		}
	}
}