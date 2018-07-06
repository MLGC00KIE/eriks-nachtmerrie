using UnityEngine;
using UnityEngine.SceneManagement;

public class gotolevelselect : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("levelselect");
	}
}