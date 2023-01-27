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
        sentences[0] = "�����: �������, ������, �� ��� ���?";
        sentences[1] = "���: ������, ��, ��� ����?";
        sentences[2] = "�����: �� �� ������";
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


