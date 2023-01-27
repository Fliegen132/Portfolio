using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    private Material Blink;
    private Material Default;
    private SpriteRenderer SpriteRender;
    public Image HealthBar;
    public float fill;
    public bool takeDamage = false;
    public GameObject endMenu;
    void Start()
    {
        endMenu.SetActive(false); 
        fill = 1f;

        SpriteRender = GetComponent<SpriteRenderer>();
        Blink = Resources.Load("EnemyBlink", typeof(Material)) as Material;
        Default = SpriteRender.material;
    }

    void Update()
    {

        HealthBar.fillAmount = fill;
        if (fill >= 1) 
        {
            fill = 1f;
        }

        if (fill <= 0)
        {
            gameObject.SetActive(false);
            Time.timeScale = 0f;
            endMenu.SetActive(true);
        }
        if(takeDamage == true) {
            SpriteRender.material = Blink;
            Invoke("ResetMat", 0.2f);
        }
    }
    void ResetMat()
    {
        takeDamage = false;
        SpriteRender.material = Default;
    }
}
