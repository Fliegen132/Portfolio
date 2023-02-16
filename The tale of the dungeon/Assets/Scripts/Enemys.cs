using UnityEngine;

public class Enemys : MonoBehaviour
{
    public BattleStart battleStart;

    public string Name;

    public int minDamage;
    public int maxDamage;
    public int LVL;

    public int maxHP;
    public int currentHP;

    public GameObject Prefab;
    private Transform player;

    private void Start()
    {
        player = Player.singleton.transform;
        battleStart = FindObjectOfType<BattleStart>();
        
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance == 0)
        {
            battleStart.SetButtle(Name, minDamage, maxDamage, maxHP, currentHP, Prefab, LVL);
            Destroy(gameObject);
        }
    }
}

