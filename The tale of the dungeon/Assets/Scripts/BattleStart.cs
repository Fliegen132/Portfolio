using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class BattleStart : MonoBehaviour
{
    public BattleSystem battleSystem;
    private Animator anim;

    public GameObject Cam;

    public EnemyInbattle enemy;
    public PlayerInBattle player;

    public Transform PlayerBattlePlatform;
    public Transform EnemyBattlePlatform;

    public GameObject PlayerPrefab;

    public BattleHUD EnemyBattleHUD;
    public BattleHUD PlayerBattleHUD;

    public Image Fade;
    private void Start()
    {
        anim = GetComponent<Animator>();
        Fade.enabled = false;
    }

    public void SetButtle(string name, int minDamage, int maxDamage, int maxHP, int currentHP, GameObject Prefab, int LVL)
    {
        Fade.enabled = true;
        battleSystem.state = BattleState.START;
        GameObject enemyGO = Instantiate(Prefab, EnemyBattlePlatform);
        enemy = enemyGO.GetComponent<EnemyInbattle>();
        enemy.SetStats(name, minDamage, maxDamage, maxHP,currentHP, LVL);

        GameObject playerGO = Instantiate(PlayerPrefab, PlayerBattlePlatform);
        player = playerGO.GetComponent<PlayerInBattle>();

        PlayerBattleHUD.SetPlayerHUD(player);
        EnemyBattleHUD.SetEnemyHUD(enemy);

        anim.SetBool("Fade", true);

    }


    public void CameraPosition(int _pos)
    {
        Cam.transform.position = new Vector3(_pos, 0, -10);
    }

    public void FadeComplite()
    {
        anim.SetBool("Fade", false);
        Fade.enabled = false;
        battleSystem.WaitTurn();
    }
}
