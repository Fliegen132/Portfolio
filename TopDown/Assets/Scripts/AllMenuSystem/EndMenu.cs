using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndMenu : MonoBehaviour
{
    public GameObject Cam, Cam2;
    public void restart() {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
        Cam.SetActive(true);
        Cam2.SetActive(false);
    }

    public void offGame() 
    {

        Application.Quit();
    }
}
