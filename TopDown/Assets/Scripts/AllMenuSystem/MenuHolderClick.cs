using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuHolderClick : MonoBehaviour
{
    public GameObject Holder;
    public MenuHolder men;
    public GameObject cam, cam2;
    public void Continue()
    {
        Holder.SetActive(false);
        Time.timeScale = 1f;
        men.Pause = false;

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
        cam.SetActive(true);
        cam2.SetActive(false);
    }

    public void offGame()
    {
        Application.Quit();
    }

    public void DeleteAll()
    {
        PlayerPrefs.DeleteKey("TimeMin"); 
        PlayerPrefs.DeleteKey("TimeSec");
    }
}
