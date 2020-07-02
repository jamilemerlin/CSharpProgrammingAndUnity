using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    // for spawning
    [SerializeField]
    GameObject GreenRockPrefab;
    [SerializeField]
    GameObject MagentaRockPrefab;
    [SerializeField]
    GameObject WhiteRockPrefab;

    // delay spawn control
    const float MinSpawnDelay = 1;
    const float MaxSpawnDelay = 2;
    Timer spawnTimer;

    // spawn location support
    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;

    int minSpawnY;
    int maxSpawnY;

    /// <summary>
    /// This for inicialization
    /// </summary>
    void Start()
    {
        // spawn boundaries
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;

        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.Run();

    }

    // Update is called once per frame
    void Update()
    { 
        // check for time to spawn a new Teddy bear
        if (spawnTimer.Finished)
        {
            SpawnRock();

            // change spanw timer duration and restart
            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
        }

    }

    void SpawnRock()
    {
        // generate random location
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        int totalRocks = GameObject.FindGameObjectsWithTag("RockPrefab").Length;

        if (totalRocks >= 3)
        {
            return;
        }

        // spawn random prefab
        int prefabNumber = Random.Range(0, 3);
        
        if (prefabNumber == 0)
        {
            Instantiate<GameObject>(GreenRockPrefab, worldLocation, Quaternion.identity);
        }
        else if (prefabNumber == 1)
        {
            Instantiate<GameObject>(WhiteRockPrefab, worldLocation, Quaternion.identity);
        }
        else
        {
            Instantiate<GameObject>(MagentaRockPrefab, worldLocation, Quaternion.identity);
        }
    }
}
