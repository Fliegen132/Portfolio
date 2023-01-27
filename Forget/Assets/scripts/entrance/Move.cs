using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
 
    private Rigidbody2D rb;
    public Animator anim;
    [SerializeField]
    public float speed;
    [SerializeField]
    private float rotationSpeed;
    public Vector2 movementDirection;



    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    

    public void Update() {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        anim.SetFloat("Horizontal", movementDirection.x);
        anim.SetFloat("Vertical", movementDirection.y);
        anim.SetFloat("speed", movementDirection.sqrMagnitude);
        movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);

        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

        }
    }


    

}
    
   