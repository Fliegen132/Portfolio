using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class messenger : MonoBehaviour
{
    public GameObject a, b, c, d;

    public GameObject off;

    public void mess()
    {
        a.SetActive(true);
        if (a == true)
        {
            off.SetActive(false);
            Invoke("mess1", 2f);
        }
    }
    void mess1()
    {
        b.SetActive(true);
        if (b == true)
        {
            Invoke("mess2", 2f);
        }
    }
    void mess2()
    {
        c.SetActive(true);
        if (c == true)
        {
            Invoke("mess3", 2f);

        }
    }
    void mess3()
    {
        d.SetActive(true);


    }

}
