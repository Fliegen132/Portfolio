using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInbattle : MonoBehaviour
{
    public string Name;

    public int minDamage;
    public int maxDamage;

    public int maxHP;
    public int currentHP;
    public int LVL;

    public void SetStats(string _name, int _minDamage, int _maxDamage, int _maxHP, int _currentHP, int _LVL)
    { 
        Name = _name;
        minDamage = _minDamage;
        maxDamage = _maxDamage;
        maxHP = _maxHP;
        currentHP = _currentHP;
        LVL = _LVL;
    }

    public bool TakeDamage(int damage)
    { 
        currentHP -= damage;

        if (currentHP <= 0)
            return true;
        else 
            return false;
    }
}
