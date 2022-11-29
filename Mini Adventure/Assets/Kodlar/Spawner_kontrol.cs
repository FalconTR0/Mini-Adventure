using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_kontrol : MonoBehaviour
{
    public GameObject dusmanPrefab;
    public Transform[] Spawnpoint;
    public float interval;
    void Start()
    {
        InvokeRepeating("spawn", 0.5f, interval);
    }

    private void spawn()
    {
        int randPos = Random.Range(0, Spawnpoint.Length);
        GameObject newDusman = Instantiate(dusmanPrefab, Spawnpoint[randPos].position, Quaternion.identity);
    }
}
