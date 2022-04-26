using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController controller;

    void Start()
    {
        InvokeRepeating("spawnObstacle", startDelay, repeatRate);
        controller = GameObject.Find("Player").GetComponent<PlayerController>();
    }



    void spawnObstacle()
    {
        if(controller.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }

  


}
