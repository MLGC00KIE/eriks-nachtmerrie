using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NotGrounded : MonoBehaviour {
    public bool isGrounded;
    // script om niet langs de muren te kunnen springen.
    void Update () { isGrounded = false; }}
