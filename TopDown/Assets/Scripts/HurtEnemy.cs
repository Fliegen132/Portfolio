using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    public int damageGive = 2;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy") {
            EnemyHealh enemyHP;
            enemyHP = other.gameObject.GetComponent<EnemyHealh>();
            enemyHP.HurtEnemy(damageGive);
        }
    }
}
