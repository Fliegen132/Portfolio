using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Dialoge : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float TypingSpeed;
    
    private void Start()
    {
        sentences[0] = "Эдгар: Здарова, братан, ну что идём?";
        sentences[1] = "Боб: Привет, да, как дела?";
        sentences[2] = "Эдгар: Да всё ништяк";
        StartCoroutine(Type());
    }
        private void Update()
        {
        
        if (textDisplay.text == sentences[index] && (Input.GetKeyUp(KeyCode.E)))
            {
                Next();
            }
        }
        IEnumerator Type() {
            foreach (char letter in sentences[index].ToCharArray()) {
                textDisplay.text += letter;
                yield return new WaitForSeconds(TypingSpeed);
            
        }
        }
        public void Next() {

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        }
    }


