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
        HP.text = "��������:" + player.currentHP.ToString();
        LVL.text = "�������:" + player.LVL.ToString();
    }
    public void SetEnemyHUD(EnemyInbattle enemy)
    {
        Name.text = enemy.Name;
        HP.text = "��������:" + enemy.currentHP.ToString();
        LVL.text = "�������:" + enemy.LVL.ToString();
    }


    public void SetHP(int hp)
    {
        HP.text = "��������:" + hp.ToString();
    }
}
