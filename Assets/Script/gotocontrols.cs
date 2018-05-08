using UnityEngine;
using UnityEngine.SceneManagement;

public class gotocontrols : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("controls");
	}
}