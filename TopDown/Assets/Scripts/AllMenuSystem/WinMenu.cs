using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WinMenu : MonoBehaviour
{
    public GameObject Menu;
    public Text WinnerText;
    public Timer timer;
    [SerializeField] Text BestTimeText;
    public GameObject cam,cam2;
    private void Start()
    {
        PlayerPrefs.Save();
        Menu.SetActive(false);
    }
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") == false) 
        {
            
            Menu.SetActive(true);
            WinnerText.text = "Поздравляем! Ваш рекорд: " + timer.min.ToString("D2") + ":" + timer.sec.ToString("D2");
            Time.timeScale = 0;

            if (!PlayerPrefs.HasKey("TimeMin") && !PlayerPrefs.HasKey("TimeSec"))
            {
                PlayerPrefs.SetInt("TimeMin", timer.min);
                PlayerPrefs.SetInt("TimeSec", timer.sec);
            }
            if (timer.min <= PlayerPrefs.GetInt("TimeMin") && timer.sec <= PlayerPrefs.GetInt("TimeSec"))
            {
                PlayerPrefs.SetInt("TimeMin", timer.min);
                PlayerPrefs.SetInt("TimeSec", timer.sec);
                
            }
            PlayerPrefs.Save();
        }
        
        if(PlayerPrefs.HasKey("TimeMin") && PlayerPrefs.HasKey("TimeSec"))
            BestTimeText.text = "Лучший рекорд:" + PlayerPrefs.GetInt("TimeMin").ToString("D2") + ":" + PlayerPrefs.GetInt("TimeSec").ToString("D2");
        else
        {
            BestTimeText.text = "Нет рекордов";
        }
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        cam.SetActive(true);
        cam2.SetActive(false);
    }
}
