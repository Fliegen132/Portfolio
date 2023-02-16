using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player singleton { get; private set; }

    [Header("Defoult stats")]
    public int MaxHP;
    public int currentHp;
    public int MinDamage;
    public int MaxDamage;
    public int LVL;

    public Weapons weapon;

    public int minAverageDamage;
    public int maxAverageDamage;
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

    }

    private void Update()
    {
        if (weapon != null)
        {
            minAverageDamage = MinDamage + weapon.minDamage;
            maxAverageDamage = MaxDamage + weapon.maxDamage;
        }
        else 
        {
            minAverageDamage = MinDamage;
            maxAverageDamage = MaxDamage;
        }
       
    }

}
