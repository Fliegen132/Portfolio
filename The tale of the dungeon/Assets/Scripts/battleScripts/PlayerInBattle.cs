using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInBattle : MonoBehaviour
{
    public int LVL;
    public int minDamage;
    public int maxDamage;

    public int currentHP;
    public int maxHP;

    private Player player;

    public IWeaponble _weapon;
    private void Awake()
    {
        player = FindObjectOfType<Player>();
        minDamage = player.minAverageDamage;
        maxDamage = player.maxAverageDamage;

        currentHP = player.currentHp;
        maxHP = player.MaxHP;

        LVL = player.LVL;
        if(player.weapon != null)
            _weapon = player.weapon.GetComponent<IWeaponble>();
    }

    private void Update()
    {
        currentHP = player.currentHp;

        if (player.weapon == null)
            _weapon = null;
    }

    public int Attack(EnemyInbattle enemy)
    {

        Debug.Log("Атака рукой");
        int damage = Random.Range(player.minAverageDamage, player.maxAverageDamage);
        
        enemy.TakeDamage(damage);

        return damage;
    }

    public bool TakeDamage(int damage)
    {
        currentHP -= damage;
        player.currentHp -= damage;

        if (currentHP <= 0)
            return true;
        else
            return false;   
    }

}
