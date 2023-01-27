using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Russian : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    public GameObject ps;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
    }

    private void Update()
    {
        if (rb.velocity.magnitude <= 1)
        {
            rb.velocity = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Block"))
        {
            Instantiate(ps, collision.transform.position, Quaternion.identity);
            rb.velocity = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
            collision.gameObject.layer = LayerMask.NameToLayer("RussianZone");
            collision.gameObject.GetComponent<Renderer>().material.color = new Color(255,0 ,0 ,1);
        }
        if (collision.gameObject.CompareTag("Gran"))
        {
            rb.velocity = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        }
    }
}
