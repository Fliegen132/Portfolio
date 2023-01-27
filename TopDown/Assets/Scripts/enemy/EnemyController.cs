using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator anim;
    private Transform target;
    public Transform homePos;
    
    [SerializeField]private float speed;
    [SerializeField] private float maxrange;
    [SerializeField] private float minrange;
    void Start()
    {
        speed = 1f;
        maxrange = 6f;
        minrange = 1.4f;
        anim = GetComponent<Animator>();
        target = FindObjectOfType<PlayerController>().transform;
    }

    
    void FixedUpdate()
    {
        if (Vector3.Distance(target.position, transform.position) <= maxrange && Vector3.Distance(target.position, transform.position) >= minrange)
        {
            FollowTarget();
        }
        else if(Vector3.Distance(target.position, transform.position) >= maxrange){
            moveHome();
        }

        if (Vector3.Distance(target.position, transform.position) <= minrange) {

            AttackTarget(); 
            
        }
        else if (Vector3.Distance(target.position, transform.position) >= minrange)
        {
            anim.SetBool("isAttack", false);
        }
    }

    public void AttackTarget() {
        anim.SetBool("isAttack", true);
    }
   

    public void FollowTarget()
    {
        anim.SetBool("isMoving", true);
        anim.SetFloat("moveX", (target.position.x - transform.position.x));
        anim.SetFloat("moveY", (target.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
    
    }

    public void moveHome()
    {
        anim.SetFloat("moveX", (homePos.position.x - transform.position.x));
        anim.SetFloat("moveY", (homePos.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, homePos.position, speed * Time.fixedDeltaTime);

        if (Vector3.Distance(homePos.position, transform.position) == 0) {
            anim.SetBool("isMoving", false);
        }
    }
}
