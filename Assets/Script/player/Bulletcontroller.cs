using System.Collections;
using UnityEngine;

public class Bulletcontroller : MonoBehaviour
{

    public float speed;
    private Rigidbody _rb;

    // Use this for initialization
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        _rb.velocity = new Vector3(speed, _rb.velocity.y);

    }
}


