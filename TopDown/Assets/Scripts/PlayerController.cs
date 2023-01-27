using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Animator anim;
    public float x, y;
    public Rigidbody2D rb;
    public Vector3 direct;
    public bool isWalking;
    public bool isAttack;
    void Start()
    {
        speed = 150f;
        anim = GetComponent<Animator>(); 
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, -4);
        Time.timeScale = 1f;
    }

    private void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (x != 0 || y != 0)
        {
            anim.SetFloat("Horizontal", x);
            anim.SetFloat("Vertical", y);
            if (!isWalking)
            {
                isWalking = true;
                anim.SetBool("isMoving", isWalking);
            }

        }
        else if (isWalking)
        {
            
            isWalking = false;
            anim.SetBool("isMoving", isWalking);
            StopMoving();
            
        }
        direct = new Vector3(x, y).normalized;

        if (Input.GetMouseButtonDown(0)) {
            if (!isAttack)
            {
                speed = 0;
                isAttack = true;
                anim.SetBool("isAttack", isAttack);
            }
        }
    }
    void FixedUpdate()
    {
        rb.velocity = direct * speed * Time.deltaTime;
    }

    private void StopMoving() {
        rb.velocity = Vector3.zero;
    }

    public void AfterAttack() 
    {
        isAttack = false;
        anim.SetBool("isAttack", isAttack);
        speed = 150f;
    }

}
