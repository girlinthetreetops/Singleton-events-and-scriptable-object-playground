using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private GameObject obstaclePrefab;

    private void Start()
    {
        GameManager.gameManager.OnGameStarted.AddListener(StartSpawning);

        GameManager.gameManager.OnGamePause.AddListener(StopSpawning);
        GameManager.gameManager.OnGameOver.AddListener(StopSpawning);
    }

    public void StartSpawning()
    {
        InvokeRepeating("SpawnSomething", 0, 1);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnSomething");
    }

    public void SpawnSomething()
    {
        Instantiate(obstaclePrefab, spawnPosition);
    }

}
