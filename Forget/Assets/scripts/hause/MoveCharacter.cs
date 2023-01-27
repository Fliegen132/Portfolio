using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveVector;
    public float speed = 2f;
    public Animator anim;
    public SpriteRenderer sr;
    private bool facingLeft = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        moveVector = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVector));
        rb.velocity = new Vector2(moveVector * speed, rb.velocity.y);
        if (facingLeft == false && moveVector > 0)
        {
            flip();

        }
        else if (facingLeft == true && moveVector < 0)
        {
            flip();
        }
    }

    void flip()
    {
        facingLeft = !facingLeft;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
