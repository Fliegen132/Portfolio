using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class ReloadScene : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DOTween.Clear(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
