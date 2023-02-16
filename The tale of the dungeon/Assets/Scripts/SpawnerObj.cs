using UnityEngine;

public class SpawnerObj : MonoBehaviour
{
    [SerializeField] private GameObject[] unit;

    public GameObject[] Object;
    public GameObject Player;

    public int Iterations = 3;
    private void Awake()
    {
        unit = GameObject.FindGameObjectsWithTag("Units");
        Spawn(Player, 1);
    }
    private void Start()
    {

        int Value;
        for (int i = 0; i < Iterations; i++)
        {
            Value = Random.Range(0, Object.Length);
            Spawn(Object[Value], 1);
        }
    }

    private void Spawn(GameObject GO, int k)
    {
        for (int i = 0; i < k; i++)
        {
            int b;
            b = Random.Range(0, unit.Length);
            if (unit[b] != null)
            {
                Instantiate(GO, unit[b].transform.position, Quaternion.identity);
                unit[b] = null;
            }
            else i--;
        }
    }
}
