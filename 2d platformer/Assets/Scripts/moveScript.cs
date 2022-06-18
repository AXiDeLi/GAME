using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    Rigidbody2D rb;
    SpriteRenderer sr;
    float temp;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    void Update() {
        float move = Input.GetAxis("Horizontal"); 
        transform.position += new Vector3(move, 0, 0) * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.05)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        if (move != 0)
        {
            temp = move;
        }
        sr.flipX = temp < 0 ? true : false;
    }
    void FixedUpdate() {
        
    }
}