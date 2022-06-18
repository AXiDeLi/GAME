using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public Transform Player;
    public float Speed;
    private int temp;
    public float AgrDist;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Mathf.Abs(Player.position.x - transform.position.x) < 0.2)
        {
            temp = 1;
        }
        else temp = 0;

        float distToPlayer = Vector2.Distance(transform.position, Player.position);
       if (distToPlayer < AgrDist)
        {
            Startpizdec();
        }
       else
        {
            Stoppizdec();
        }
        Debug.Log(Mathf.Abs(Player.position.x - transform.position.x));

    }
    void Startpizdec()
    {
        
            if (Player.position.x < transform.position.x)
            {
                rb.velocity = new Vector2(-Speed, 0);
                if (temp != 1)
                {
                    sr.flipX = true;
                }
            }
            else if (Player.position.x > transform.position.x)
            {
                rb.velocity = new Vector2(Speed, 0);
                if (temp != 1)
                {
                    sr.flipX = false;
                }
            }
        
    }
    void Stoppizdec()
    {
        rb.velocity = new Vector2(0, 0);
    }
}
