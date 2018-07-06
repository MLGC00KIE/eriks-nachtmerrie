using UnityEngine;
using UnityEngine.SceneManagement;

public class win2 : MonoBehaviour {
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			SceneManager.LoadScene ("win2");

		}
	}
}
