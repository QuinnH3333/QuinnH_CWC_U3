using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsticalPrefab;
    private Vector3 spawnLocation = new Vector3 (25, 0, 0);
    float startDelay = 2;
    float repeatRate = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstical", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstical()
    {
        if (playerControllerScript.gameOver == false) {
            Instantiate(obsticalPrefab, spawnLocation, obsticalPrefab.transform.rotation);
        } }
}
