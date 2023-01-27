using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WeaponInfo : MonoBehaviour
{
    public Text nameText;
    public Text infoText;
    public Text damage;
    public Image _image;
    public GameObject haveGun;

    public Weapons Weapons;

    public Player player;

    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        player = FindObjectOfType<Player>();
        haveGun.SetActive(false);
    }
    public void setInfo(Weapons weapon)
    {
        _image.sprite = weapon.image;
        infoText.text = weapon._info;
        nameText.text = weapon.Name;
        damage.text = "Урон: " + weapon.minDamage.ToString() + "-" + weapon.maxDamage.ToString();

        Weapons = weapon;

        anim.Play("OpenInfo");
    }

    public void TakeWeapon()
    {
        if (player.weapon == null)
        { 
            player.weapon = Weapons;
        }
        else
        {
            haveGun.SetActive(true);
            StartCoroutine(hide());
        }

    }

    private IEnumerator hide()
    {
        yield return new WaitForSeconds(2f);
        haveGun.SetActive(false);
    }
        
}
