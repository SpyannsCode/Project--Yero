using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField]
    private GameObject Minion;
    public GameObject MinionSpawnPosition;
    [SerializeField]
    private GameObject EnemyMinion;
    public GameObject EnemySpawnPosition;

    public int chance = 100;
    public int Space = 20;
    public int spacetemp;

    private bool IsOpen = false;

    // Update is called once per frame
    void Start()
    {
        spacetemp = Space;
    }
    void Update()
    {
        if (IsOpen)
        {
            if (chance > 0)
            {
                spacetemp--;
                if (spacetemp <= 0)
                {
                    Instantiate(Minion, MinionSpawnPosition.transform.position, transform.rotation);
                    chance--;
                    spacetemp = Space;
                }
            }
            else
                Close();
        }
        else
        {
            if (Random.Range(chance, 1001) == 1000)
                Open();
            else if (Random.Range(chance, 1001) == 100)
                chance++;
        }
    }
    private void Open()
    {
        IsOpen = true;
    }
    private void Close()
    {
        chance = 0;
        Instantiate(EnemyMinion, EnemySpawnPosition.transform.position, transform.rotation);
        IsOpen = false;
    }
}
