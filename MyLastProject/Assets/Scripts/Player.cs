using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject PlayerPoint;

    public static Player singleton { get; private set; }

    [Header("Defoult stats")]
    public static int hp = 10;
    public static int minDamage = 5;
    public static int maxDamage = 10;

    public Weapons weapon;

    public int averageDamage;
    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;

        }
        else if (singleton == this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (weapon != null)
        {
            averageDamage = (minDamage + maxDamage + weapon.maxDamage + weapon.minDamage) / 2;
        }
        else 
        {
            averageDamage = (minDamage + maxDamage) / 2;
        }
    }

}   
