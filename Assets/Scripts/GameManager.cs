using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float max_X;
    public Transform spawnPoint;
    public float spawnRate;


    bool gameStarted = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            StartSpawning();
        }
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBlock", 0.1f, spawnRate);
    }

    private void SpawnBlock()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-max_X, max_X);

        Instantiate(block, spawnPos, Quaternion.identity);
    }
}
