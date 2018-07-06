using UnityEngine;
using UnityEngine.SceneManagement;

public class WinBB : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("BossBattle");

        }
    }
}
