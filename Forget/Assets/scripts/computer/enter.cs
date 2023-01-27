using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class enter : MonoBehaviour
{
    private string userPassword;
    public string password = "0214";
    public Button but;
    public Text entryField;
    public GameObject a,b;

    private void Start()
    {
        but.onClick.AddListener(Enter);
    }
    void Enter() {
        userPassword = entryField.GetComponent<Text>().text;
        if (userPassword == password) {
            a.SetActive(false);
            b.SetActive(true);

        }
        
    }

}