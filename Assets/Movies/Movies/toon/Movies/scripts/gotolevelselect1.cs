using UnityEngine;
using UnityEngine.SceneManagement;

public class gotolevelselect1 : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("levelselect1");
	}
}