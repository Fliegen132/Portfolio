using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleHUD : MonoBehaviour
{
    public Text Name;
    public Text HP;
    public Text LVL;

  
    public void SetPlayerHUD(PlayerInBattle player)
    {
        HP.text = "Здоровье:" + player.currentHP.ToString();
        LVL.text = "Уровень:" + player.LVL.ToString();
    }
    public void SetEnemyHUD(EnemyInbattle enemy)
    {
        Name.text = enemy.Name;
        HP.text = "Здоровье:" + enemy.currentHP.ToString();
        LVL.text = "Уровень:" + enemy.LVL.ToString();
    }


    public void SetHP(int hp)
    {
        HP.text = "Здоровье:" + hp.ToString();
    }
}
