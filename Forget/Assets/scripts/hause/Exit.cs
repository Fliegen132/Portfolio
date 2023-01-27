using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    public GameObject hint;
    public GameObject Player;
    private bool PlayerDetec;
    public Transform pos;
    public float width;
    public float height;
    public LayerMask WhatisPlayer;
    public int Scene;

    private void Update()
    {
        PlayerDetec = Physics2D.OverlapBox(pos.position, new Vector2(width, height), 0, WhatisPlayer);

        if (PlayerDetec == true)
        {

            hint.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(Scene);
            }
        }

        if (PlayerDetec == false)
        {
            hint.SetActive(false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(pos.position, new Vector3(width, height, 1));
    }

}

