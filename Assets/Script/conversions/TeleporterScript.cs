using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterScript : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Teleporter1")
        {
            transform.position = new Vector3((float)-1.608, (float)-4.28, 0);
        }
        if (collision.gameObject.tag == "Teleporter2")
        {
            transform.position = new Vector3(1, (float)-13.82, 0);
        }
        if (collision.gameObject.tag == "Teleporter3")
        {
            transform.position = new Vector3((float)-3.305, (float)-6.977, 0);
        }
    }
}
