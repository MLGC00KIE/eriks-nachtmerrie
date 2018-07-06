using UnityEngine;
using UnityEngine.SceneManagement;

public class gotolevel1 : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("test");
	}
}