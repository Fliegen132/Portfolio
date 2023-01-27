using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") 
        {
            Health HP;
            HP = other.gameObject.GetComponent<Health>();
            HP.fill += -0.2f;
            HP.takeDamage = true;
        }
    }
}
