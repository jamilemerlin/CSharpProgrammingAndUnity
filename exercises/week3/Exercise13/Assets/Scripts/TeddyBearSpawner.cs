using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


/// <summary>
/// A Teddy bear spawner
/// </summary>
public class TeddyBearSpawner : MonoBehaviour
{
    // needed for spawning
    [SerializeField]
    GameObject prefabYellowTeddyBear;
    [SerializeField]
    GameObject prefabGreenTeddyBear;
    [SerializeField]
    GameObject prefabPurpleTeddyBear;

    //spawn control
    const float MinSpawnDelay = 0.5f;
    const float MaxSpawnDelay = 1;
    Timer spawnTimer;

    // spawn location support
    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;

    int minSpawnY;
    int maxSpawnY;

    /// <summary>
    /// Use this for inicialization
    /// </summary>
    void Start()
    {
        // save spawn boundaries for efficiency
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;

        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

        // create and start timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        spawnTimer.Run();
    }

    /// <summary>
    /// Update is called onde per frame
    /// </summary>
    void Update()
    {
        // check for time to spawn a new Teddy bear
        if (spawnTimer.Finished)
        {
            SpawnBear();

            // change spanw timer duration and restart
            spawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            spawnTimer.Run();
        }
    }

    void SpawnBear()
    {
        // generate random location and crear a new Teddy bear
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        // spawn random prefab
        int prefabNumber = Random.Range(0, 3);
        /*int prefabNumber = 0;*/
        if (prefabNumber == 0)
        {
            GameObject teddyBear = Instantiate<GameObject>(prefabYellowTeddyBear, 
                worldLocation, Quaternion.identity);
            teddyBear.tag = "C4TeddyBear";
        }
        else if (prefabNumber == 1)
        {
            Instantiate<GameObject>(prefabGreenTeddyBear, worldLocation, Quaternion.identity);
        }
        else
        {
            Instantiate<GameObject>(prefabPurpleTeddyBear, worldLocation, Quaternion.identity);
        }
    }
}
