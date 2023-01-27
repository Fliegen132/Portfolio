using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Photo : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    
    private int index;
    public float TypingSpeed;
    public GameObject on;
    public GameObject hint;
    public GameObject Player;
    private bool PlayerDetec;
    public Transform pos;
    public float width;
    public float height;
    public LayerMask WhatisPlayer;
    public string[] sentences;
    private void Update()
    {
        PlayerDetec = Physics2D.OverlapBox(pos.position, new Vector2(width, height), 0, WhatisPlayer);
        if (PlayerDetec == true)
        {
            hint.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Dial();
                StartDialoge();
                on.SetActive(true);

                if (textDisplay.text == sentences[index] && Input.GetKeyDown(KeyCode.E))
                {
                        Next();
                }
                else
                {
                    StopAllCoroutines();
                    textDisplay.text = sentences[index];
                }
            }
        }
        if (PlayerDetec == false)
        {
            hint.SetActive(false);
            on.SetActive(false);
        }
    }
    public void Dial() {
        sentences[0] = "Я с девушкой, её волосы всегда пахнут сиренью и крыжовником.";
    }
    public void StartDialoge()
    {
        StartCoroutine(Type());
    }
    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(TypingSpeed);
        }
        
    }
    public void Next() {

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = string.Empty;
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = string.Empty;
            on.SetActive(false);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(pos.position, new Vector3(width, height, 1));
    }
}


