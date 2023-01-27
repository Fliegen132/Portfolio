using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chenge : MonoBehaviour
{
    public GameObject hint;
    public GameObject Player;
    public GameObject Doors;
    private bool PlayerDetec;
    public Transform pos;
    public float width;
    public float height;
    public LayerMask WhatisPlayer;
    public GameObject on;
    public GameObject off;
    public GameObject fade;

    private void Update()
    {
        PlayerDetec = Physics2D.OverlapBox(pos.position, new Vector2(width, height), 0, WhatisPlayer);

        if (PlayerDetec == true)
        {
            hint.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(Fade());
            }
        }

        if (PlayerDetec == false)
        {
            hint.SetActive(false);
        }
    }

    IEnumerator Fade()
    {
        fade.SetActive(true);
        on.SetActive(true);
        off.SetActive(false);
        Player.transform.position = new Vector2(Doors.transform.position.x, Doors.transform.position.y);

        yield return new WaitForSeconds(2f);
        StartCoroutine(FadeOff());
    }
    IEnumerator FadeOff() {
        fade.SetActive(false);
        yield return null;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(pos.position, new Vector3(width, height, 1));
    }

}
