using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerThree : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 2;
    public float repeatRate = 2;
    private PlayerControllerThree playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerThree>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver ==false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }  
    }
}
