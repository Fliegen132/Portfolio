using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject LostWindow;
    public BattleState state;

    public Text DialogueText;
    public Text DialogueText2;
    public GameObject TextBox;
    public BattleStart battleStart;

    public IWeaponble playerWeapon;

    public void Start()
    {
        LostWindow.SetActive(false);
        TextBox.SetActive(false);
    }

    public void WaitTurn()
    {
        if (battleStart.player._weapon != null)
        {
            playerWeapon = battleStart.player._weapon;
        }
        StartCoroutine(writeText(battleStart.enemy.Name.ToString() + ", крадеца", DialogueText));
        StartCoroutine(PlayerTurn());
    }

    IEnumerator PlayerTurn()
    {
        TextBox.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(writeText("Выберите действие:", DialogueText));
        yield return new WaitForSeconds(0.5f);
        state = BattleState.PLAYERTURN;
    }
    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;
        else
        {
            DialogueText.text = "";
            StartCoroutine(PlayerAttack());
            TextBox.SetActive(true);
        }
    }

    IEnumerator PlayerAttack()
    {
        int damage;
        if (battleStart.player._weapon == null)
            damage = battleStart.player.Attack(battleStart.enemy);
        else
            damage = playerWeapon.Attack();

        StartCoroutine(writeText("Вы нанесли " + damage.ToString() + " урона", DialogueText2));
       
        
        bool isDead = battleStart.enemy.TakeDamage(0);
        battleStart.EnemyBattleHUD.SetHP(battleStart.enemy.currentHP);
        state = BattleState.ENEMYTURN;

        yield return new WaitForSeconds(2f);
        if (isDead)
        {
            state = BattleState.WON;
            battleStart.CameraPosition(0);
            Destroy(battleStart.enemy.gameObject);
            Destroy(battleStart.player.gameObject);
        }
        else
        {
            Debug.Log("Tetxt");
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator EnemyTurn()
    {
        StartCoroutine(writeText("Ход врага!", DialogueText2));

        int damage = Random.Range(battleStart.enemy.minDamage, battleStart.enemy.maxDamage);
        yield return new WaitForSeconds(1f);

        bool isDead = battleStart.player.TakeDamage(damage);
        StartCoroutine(writeText("Вам нанесли: " + damage.ToString() + " урона", DialogueText2));
        battleStart.PlayerBattleHUD.SetHP(battleStart.player.currentHP);
        yield return new WaitForSeconds(1f);
        if (isDead)
        {
            state = BattleState.LOST;
            LostWindow.SetActive(true);
            Destroy(battleStart.player.gameObject);
        }
        else 
        {
            StartCoroutine(PlayerTurn());
        }
    }


    IEnumerator writeText(string Text, Text text)
    {
        text.text = "";
        for (int i = 0; i < Text.Length; i++)
        {
            text.text += Text[i];
            yield return new WaitForSecondsRealtime(0.005f);
        }
    }
}
