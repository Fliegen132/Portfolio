using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class UnitForPlayer : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject[] unit;
    [SerializeField] private float distance;

    private Transform player;

    private bool isMoving;
    [SerializeField] private Vector3 newTarget; 
    private void Start()
    {
        isMoving = false;
        unit = GameObject.FindGameObjectsWithTag("Units");
        player = Player.singleton.transform;
    }
    [SerializeField]private int i;
    private void Update()
    {

        for (i = 0; i < unit.Length; i++)
        {
            distance = Vector3.Distance(player.transform.position, unit[i].transform.position);
            if (distance <= 2)
            {
                unit[i].gameObject.SetActive(true);
            }
            else
            {
                unit[i].gameObject.SetActive(false);
            }
            if (distance == 0)
            {
                unit[i].gameObject.SetActive(false);
            }
        }

        if (isMoving)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position,
                newTarget, 10 * Time.deltaTime);
        }
        if (player.transform.position == newTarget)
        {
            isMoving = false;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        newTarget = eventData.rawPointerPress.transform.position;
        isMoving = true;
    }

    
}
