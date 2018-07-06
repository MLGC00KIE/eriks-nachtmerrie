//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//
//public class HealthBar : MonoBehaviour {
//    private Image healthBar;
//    private float maxHealth = 3f;
//	public static float health;
//
//    private void Start () {
//		healthBar = GetComponent<Image> ();
//		health = maxHealth;
//	}
//
//    // Update is called once per frame
//    private void Update () {
//		healthBar.fillAmount = health / maxHealth;
//	}
//}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    //variabelen
    public float TotalHp;
    public static float Health;

    void Start()
    { Health = TotalHp; }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Health > 0)
            { TakeDamage();}

            else
            { print("Dead"); }
        }

    }
    // scale van healtbar ( x as veranderen )
    void TakeDamage()
    {
        Health -= 5;
        transform.localScale = new Vector3((Health / TotalHp), 1, 1);
    }




}

