using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Shampoos : MonoBehaviour
{
    public GameObject on;
    public GameObject hint;
    public GameObject Player;
    private bool PlayerDetec;
    public Transform pos;
    public float width;
    public float height;
    public LayerMask WhatisPlayer;
    private void Update()
    {
        PlayerDetec = Physics2D.OverlapBox(pos.position, new Vector2(width, height), 0, WhatisPlayer);
        if (PlayerDetec == true)
        {
            hint.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                on.SetActive(true);
                Time.timeScale = 0;
            }
           
        }
        if (PlayerDetec == false)
        {
            hint.SetActive(false);
        }
    }


    public void TimeOn() {
        Time.timeScale=1;
    
    }
   
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(pos.position, new Vector3(width, height, 1));
    }
}


