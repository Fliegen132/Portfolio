using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knifes : Weapons
{
    private void Start()
    {
        info();
    }
    private void Update()
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
