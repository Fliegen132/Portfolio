using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHUD : MonoBehaviour
{
    public Text hpText;
    public Text PlayerDamageText;

    public GameObject window;

    public Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public void Update()
    {
        hpText.text = "Здоровье: " +  Player.hp.ToString();
        PlayerDamageText.text = "Урон: ~" + player.averageDamage;
        if (player.weapon != null)
        { 
            player.weapon.transform.position = window.transform.position;
        }
    }

    public void bnt()
    {
        if(player.weapon != null)
            Destroy(player.weapon.gameObject);
    }

}
