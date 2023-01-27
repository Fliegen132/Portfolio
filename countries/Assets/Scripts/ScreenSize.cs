using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour
{
    private void Start()
    {
        Screen.SetResolution(550, 1000, false);
    }

}
