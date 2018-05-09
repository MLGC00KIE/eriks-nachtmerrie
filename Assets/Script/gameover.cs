using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {
	void OnCollisionEnter(Collision collision)
{
	if (collision.gameObject.tag == "Player")
	{
		SceneManager.LoadScene ("gameover");
		
	}
}
}