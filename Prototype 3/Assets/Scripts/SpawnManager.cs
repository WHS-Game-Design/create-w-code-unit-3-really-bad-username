using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   [SerializeField] private GameObject obstaclePrefab; 

   [SerializeField] private float startDelay; 
   [SerializeField] private float spawnRate;

   private Vector3 spawnPosition =new(30, 0, 0);
    private PlayerController playerController;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        InvokeRepeating(nameof(SpawnObstacle), startDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {

    Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}
