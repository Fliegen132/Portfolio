using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SpawnCountry : MonoBehaviour
{
    [Header("Кнопки")]
    public GameObject ruBtn;
    public GameObject ukBtn;
    public GameObject polBtn;
    public GameObject belBtn;
    public GameObject kazBtn;


    public GameObject ruBtnSup;
    public GameObject ukBtnSup;
    public GameObject polBtnSup;
    public GameObject belBtnSup;
    public GameObject kazBtnSup;



    public float TimerRu = 0;
    public float TimerUk = 0;
    public float TimerPol = 0;
    public float TimerBel = 0;
    public float TimerKaz = 0;

    [Header("комба для стран")]
    public int ruCombo = 0;
    public int ukCombo = 0;
    public int polCombo = 0;
    public int belCombo = 0;
    public int kazCombo = 0;

    [Header("комба для стран(текст)")]
    public Text _ruCombo;
    public Text _ukCombo;
    public Text _polCombo;
    public Text _belCombo;
    public Text _kazCombo;

    [Header("общий счетчик")]
    public int coutner = 0;

    [Header("счетчик для стран")]
    public int r = 0;
    public int u = 0;
    public int p = 0;
    public int b = 0;
    public int k = 0;

    [Header("текст для стран")]
    public Text _ruCounter;
    public Text _ukCounter;
    public Text _polCounter;
    public Text _belCounter;
    public Text _kazCounter;


    [Header("Префабы")]
    public GameObject PrefabRussian;
    public GameObject PrefabUk;
    public GameObject PrefabPol;
    public GameObject PrefabBel;
    public GameObject PrefabKaz;


    [Header("Расположения")]
    public GameObject transformRussian;
    public GameObject transformUk;
    public GameObject transformPol;
    public GameObject transformBel;
    public GameObject transformKaz;


    private void Update()
    {
        if (TimerRu <= 1)
        {
            _ruCombo.transform.DOScale(new Vector3(5f, 1f, 1f), 0.1f);
            
        }
        else
        {
            _ruCombo.transform.DOScale(new Vector3(1f, 1f, 1f), 0);
        }
        if (TimerRu <= 0.9f)
        {
            TimerNullRu();
        }



        if (TimerUk <= 1)
        {
            _ukCombo.transform.DOScale(new Vector3(5f, 1f, 1f), 0.1f);

        }
        else
        {
            _ukCombo.transform.DOScale(new Vector3(1f, 1f, 1f), 0);
        }
        if (TimerUk <= 0.9f)
        {
            TimerNullUk();
        }


        if (TimerPol <= 1)
        {
            _polCombo.transform.DOScale(new Vector3(5f, 1f, 1f), 0.1f);

        }
        else
        {
            _polCombo.transform.DOScale(new Vector3(1f, 1f, 1f), 0);
        }
        if (TimerPol <= 0.9f)
        {
            TimerNullPol();
        }


        if (TimerBel <= 1)
        {
            _belCombo.transform.DOScale(new Vector3(5f, 1f, 1f), 0.1f);

        }
        else
        {
            _belCombo.transform.DOScale(new Vector3(1f, 1f, 1f), 0);
        }
        if (TimerBel <= 0.9f)
        {
            TimerNullBel();
        }


        if (TimerKaz <= 1)
        {
            _kazCombo.transform.DOScale(new Vector3(5f, 1f, 1f), 0.1f);

        }
        else
        {
            _kazCombo.transform.DOScale(new Vector3(1f, 1f, 1f), 0);
        }
        if (TimerKaz <= 0.9f)
        {
            TimerNullKaz();
        }

        TimerRu -= Time.deltaTime;
        TimerUk -= Time.deltaTime;
        TimerPol -= Time.deltaTime;
        TimerKaz -= Time.deltaTime;
        TimerBel -= Time.deltaTime;
    }

    public void SpawnRussian()
    {
        if (coutner <= 999)
        {
            ruBtn.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            ruBtn.transform.DOScale(Vector3.one, 0.1f);

            TimerRu = 2;
            ruCombo++;
            _ruCombo.text = "X" + ruCombo.ToString();

            r++;
            _ruCounter.text = r.ToString();
            Instantiate(PrefabRussian, transformRussian.transform.position, Quaternion.identity);
            coutner++;
            
        }
    }

    public void SpawnRussianSuper()
    {
        if (coutner <= 999)
        {
            ruBtnSup.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            ruBtnSup.transform.DOScale(Vector3.one, 0.1f);

            TimerRu = 2;
            ruCombo++;
            _ruCombo.text = "X" + ruCombo.ToString();

            r++;
            _ruCounter.text = r.ToString();
            Instantiate(PrefabRussian, transformRussian.transform.position, Quaternion.identity);
            coutner++;

        }
    }

    void TimerNullRu() 
    {
        ruCombo = 0;
        _ruCombo.text = "";
        
    }


    public void SpawnUk()
    {
        if (coutner <= 999)
        {
            ukBtn.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            ukBtn.transform.DOScale(Vector3.one, 0.1f);
            TimerUk = 2;
            ukCombo++;
            _ukCombo.text = "X" + ukCombo.ToString();

            u++;
            _ukCounter.text = u.ToString();
            Instantiate(PrefabUk, transformUk.transform.position, Quaternion.identity);
            coutner++;
        }
    }
    public void SpawnUkSuper()
    {
        if (coutner <= 999)
        {
            ukBtnSup.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            ukBtnSup.transform.DOScale(Vector3.one, 0.1f);
            TimerUk = 2;
            ukCombo++;
            _ukCombo.text = "X" + ukCombo.ToString();

            u++;
            _ukCounter.text = u.ToString();
            Instantiate(PrefabUk, transformUk.transform.position, Quaternion.identity);
            coutner++;
        }
    }
    void TimerNullUk()
    {
        ukCombo = 0;
        _ukCombo.text = "";

    }
    public void SpawnPol()
    {
        if (coutner <= 999)
        {
            polBtn.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            polBtn.transform.DOScale(Vector3.one, 0.1f);
            TimerPol = 2;
            polCombo++;
            _polCombo.text = "X" + polCombo.ToString();

            p++;
            _polCounter.text = p.ToString();
            Instantiate(PrefabPol, transformPol.transform.position, Quaternion.identity);
            coutner++;
        }
    }

    public void SpawnPolSuper()
    {
        if (coutner <= 999)
        {
            polBtnSup.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            polBtnSup.transform.DOScale(Vector3.one, 0.1f);
            TimerPol = 2;
            polCombo++;
            _polCombo.text = "X" + polCombo.ToString();

            p++;
            _polCounter.text = p.ToString();
            Instantiate(PrefabPol, transformPol.transform.position, Quaternion.identity);
            coutner++;
        }
    }
    void TimerNullPol ()
    {
        polCombo = 0;
        _polCombo.text = "";

    }
    public void SpawnBel()
    {
        if (coutner <= 999)
        {
            belBtn.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            belBtn.transform.DOScale(Vector3.one, 0.1f);
            TimerBel = 2;
            belCombo++;
            _belCombo.text = "X" + belCombo.ToString();

            b++;
            _belCounter.text = b.ToString();
            Instantiate(PrefabBel, transformBel.transform.position, Quaternion.identity);
            coutner++;
        }
    }
    public void SpawnBelSup()
    {
        if (coutner <= 999)
        {
            belBtnSup.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            belBtnSup.transform.DOScale(Vector3.one, 0.1f);
            TimerBel = 2;
            belCombo++;
            _belCombo.text = "X" + belCombo.ToString();

            b++;
            _belCounter.text = b.ToString();
            Instantiate(PrefabBel, transformBel.transform.position, Quaternion.identity);
            coutner++;
        }
    }
    void TimerNullBel()
    {
        belCombo = 0;
        _belCombo.text = "";

    }

    public void SpawnKaz()
    {
        if (coutner <= 999)
        {
            kazBtn.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            kazBtn.transform.DOScale(Vector3.one, 0.1f);
            TimerKaz = 2;
            kazCombo++;
            _kazCombo.text = "X" + kazCombo.ToString();

            k++;
            _kazCounter.text = k.ToString();
            Instantiate(PrefabKaz, transformKaz.transform.position, Quaternion.identity);
            coutner++;
        }
    }

    public void SpawnKazSup()
    {
        if (coutner <= 999)
        {
            kazBtnSup.transform.DOScale(new Vector3(2f, 2f, 1f), 0.1f);
            kazBtnSup.transform.DOScale(Vector3.one, 0.1f);
            TimerKaz = 2;
            kazCombo++;
            _kazCombo.text = "X" + kazCombo.ToString();

            k++;
            _kazCounter.text = k.ToString();
            Instantiate(PrefabKaz, transformKaz.transform.position, Quaternion.identity);
            coutner++;
        }
    }
    void TimerNullKaz()
    {
        kazCombo = 0;
        _kazCombo.text = "";

    }
}
