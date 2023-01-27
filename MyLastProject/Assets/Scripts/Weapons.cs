using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Weapons : MonoBehaviour
{
    public Sprite image;
    public string Name;

    public int minDamage;
    public int maxDamage;

    public int price;

    public Player player;

    public PlayerHUD playerHUD;
    public WeaponInfo weaponInfo;

    [TextArea(5,20)]
    public string _info;
    public void info()
    {
        GameObject playerGO;
        playerGO = GameObject.FindGameObjectWithTag("Player");
        player = playerGO.GetComponent<Player>();

        playerHUD = FindObjectOfType<PlayerHUD>();
        weaponInfo = FindObjectOfType<WeaponInfo>();
    }
}
