using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject crate;
    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted = false;

    public GameObject tapText;
    public TextMeshProUGUI scoreText;

    [SerializeField] private Player player;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        { 
            StartSpawning();

            gameStarted = true;
            tapText.SetActive(false);


        }

    }

    private void StartSpawning()
    { 
        InvokeRepeating("SpawnCrate", 0.5f,spawnRate);
    }

    private void SpawnCrate()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range(-maxX, maxX);

        Instantiate( crate, spawnPos, Quaternion.identity);

        player.attributes.currScore++;

        scoreText.text = player.attributes.currScore.ToString();
    }
}
