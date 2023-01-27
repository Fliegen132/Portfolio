using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int Scene;
    public void OnClick()
    {
        StartCoroutine("SceneSwitch");
    }
    
    IEnumerator SceneSwitch ()
    {
        
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(Scene);

    }
}
