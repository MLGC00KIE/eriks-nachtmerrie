using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtotitle : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("title");
	}
}