using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public int sec = 0;
    public int min = 0;
    private Text timerText;
    void Start()
    {
        timerText = GameObject.Find("Timer").GetComponent<Text>();

        StartCoroutine(Time());
    }
    IEnumerator Time()
    {
        while (true)
        {
            if (sec == 59)
            {
                min++;
                sec = -1;
            }
            sec += 1;
            timerText.text = min.ToString("D2") + ":" + sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }

    void Update()
    {
        
    }
}
