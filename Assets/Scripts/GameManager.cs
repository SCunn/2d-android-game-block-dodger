using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject block;
    public float max_X;
    public Transform spawnPoint;
    public float spawnRate;


    bool gameStarted = false;

    public GameObject tapText;
    public TextMeshProUGUI scoreText;

    int score = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            StartSpawning();
            // Hide the tap text
            tapText.SetActive(false);
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

        // Increase the score
        score++;
        // Convert score text to string (TMP)
        scoreText.text = score.ToString();
    }
}
