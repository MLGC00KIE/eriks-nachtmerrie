using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			SceneManager.LoadScene ("win");

		}
	}
}
