using UnityEngine;

class HeartSword : Weapons, IWeaponble
{
    private void Start()
    {
        info();
    }

    private void Update()
    {
        DistanceWeapon();
    }
    public int percent;
    int IWeaponble.Attack()
    {
        Debug.Log("Атака сердцечным мечом!");
        currentDamage = Random.Range(player.minAverageDamage, player.maxAverageDamage);

        SetEnemy();
        enemy.TakeDamage(currentDamage);
        percent = currentDamage * 25 / 100;
        player.currentHp += percent;
        BattleHud.SetHP(player.currentHp);
        Endurance--;
        if (Endurance <= 0)
        {
            DestroyWeapon();
        }
        return currentDamage;
        
    }

    
}
