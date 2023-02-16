using UnityEngine;
public class Weapons : MonoBehaviour
{
    public Weapons weapon;

    public Sprite image;
    public string Name;

    public int minDamage;
    public int maxDamage;
    public int currentDamage;
    public int Price;

    public Player player;

    public PlayerHUD playerHUD;
    public WeaponInfo weaponInfo;

    [TextArea(5, 20)]
    public string _info;
    public BattleHUD BattleHud;
    public EnemyInbattle enemy;
    public int Endurance;
    public void info()
    {
        GameObject playerGO;
        playerGO = GameObject.FindGameObjectWithTag("Player");
        player = playerGO.GetComponent<Player>();
        playerHUD = FindObjectOfType<PlayerHUD>();
        BattleHud = FindObjectOfType<BattleHUD>();
        weaponInfo = FindObjectOfType<WeaponInfo>();
        weapon = this;
    }

    public void SetEnemy()
    {
        enemy = FindObjectOfType<EnemyInbattle>();
    }

    public void DestroyWeapon()
    {
        player.weapon = null;
        Destroy(gameObject);
    }

    public void DistanceWeapon()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance == 0)
        {
            weaponInfo.setInfo(this);
        }

        if (weaponInfo.Weapons != null)
        {
            float distance2 = Vector3.Distance(player.transform.position, weaponInfo.Weapons.transform.position);
            if (distance2 != 0 && weaponInfo.Weapons != null)
            {
                weaponInfo.haveGun.SetActive(false);
                weaponInfo.anim.Play("Idle");
            }
        }
    }
    
}
