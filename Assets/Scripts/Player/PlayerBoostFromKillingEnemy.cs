using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoostFromKillingEnemy : MonoBehaviour
{
    public Rigidbody2D rb;


    public float boostForceVertical = 500f;
    public float boostForceHorizontal = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyCopule") 
        {
            rb.AddForce(new Vector2(boostForceHorizontal, boostForceVertical));
        }
    }
}
