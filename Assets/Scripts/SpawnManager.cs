using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    Spawnpoint[] spawnPoints;

    private void Awake()
    {
        Instance = this;
        spawnPoints = GetComponentsInChildren<Spawnpoint>();
    }

    public Transform GetSpawnPoint()
    {
        //Set a random seed
        Random.InitState(System.DateTime.Now.Millisecond);

        return spawnPoints[Random.Range(0, spawnPoints.Length)].transform;
    }
}
