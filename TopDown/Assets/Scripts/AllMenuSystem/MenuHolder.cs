using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHolder : MonoBehaviour
{
    public GameObject Holder;
    public bool Pause = false;
    void Start()
    {
        Holder.SetActive(false);
    }

    void Update()
    {
        if (Pause == false && Input.GetKeyDown(KeyCode.Escape))
        {
            Holder.SetActive(true);
            Time.timeScale = 0f;
            Pause = true;
        }
        else if (Pause == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Holder.SetActive(false);
            Time.timeScale = 1f;
            Pause = false;
        }

    }
}
