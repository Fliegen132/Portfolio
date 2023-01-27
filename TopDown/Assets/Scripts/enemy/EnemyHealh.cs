using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealh : MonoBehaviour
{
    public int HealthPerfomance = 10;
    public int MaxHealth = 10;

    private Material Blink;
    private Material Default;
    private SpriteRenderer SpriteRender;
    void Start()
    {
        SpriteRender = GetComponent<SpriteRenderer>();
        Blink = Resources.Load("EnemyBlink", typeof(Material)) as Material;
        Default = SpriteRender.material;
    }


    public void HurtEnemy(int damageGive) { 
        HealthPerfomance -= damageGive;
        SpriteRender.material = Blink;
        if (HealthPerfomance <= 0)
        {
            Destroy(gameObject);
        }
        else 
        {
            Invoke("ResetMat", 0.2f);
        }
    }

    void ResetMat() 
    { 
    SpriteRender.material = Default;
    }
}
