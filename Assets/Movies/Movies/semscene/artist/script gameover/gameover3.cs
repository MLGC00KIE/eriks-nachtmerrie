using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover3 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag == "Player")
        {

            SceneManager.LoadScene("gameover3");

        }
    }
}