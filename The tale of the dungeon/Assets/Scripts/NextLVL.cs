using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class NextLVL : MonoBehaviour
{
    public GameObject NewLvlWindow;
    public GameObject MainMenu;

    private void Start()
    {
        NewLvlWindow.SetActive(false);
        MainMenu.SetActive(false); ;
    }
    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") == false)
        {
            StartCoroutine(CoroutineNext());
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu.SetActive(true);
        }
    }

    IEnumerator CoroutineNext()
    {
        yield return new WaitForSeconds(2f);
        NewLvlWindow.SetActive(true);
    }

    public void ButtonLVL()
    {
        SceneManager.LoadScene(0);
    }

    public void ButtonFalseMenu()
    {
        MainMenu.SetActive(false);
    }

}
