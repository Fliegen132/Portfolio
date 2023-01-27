using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newLocat : MonoBehaviour
{
    public GameObject player;
    public GameObject hint;
    public float x, y;
    public GameObject newCam, oldCam;
    private void Start()
    {
        hint.SetActive(false);
    }
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= 1f)
        {
            hint.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)) {
                player.transform.position = new Vector3(x, y);
                oldCam.SetActive(false);
                newCam.SetActive(true);
            }
        }
        else 
        {
            hint.SetActive(false);
        }
    }
}
