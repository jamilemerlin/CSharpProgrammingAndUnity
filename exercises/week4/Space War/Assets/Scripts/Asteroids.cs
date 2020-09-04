using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    // Serialized for spawning
    [SerializeField]
    GameObject AsteroidOnePrefab;

    [SerializeField]
    GameObject AsteroidTwoPrefab;

    [SerializeField]
    GameObject AsteroidThreePrefab;

    [SerializeField]
    GameObject AsteroidFourPrefab;

    [SerializeField]
    GameObject AsteroidFivePrefab;

    // spawn control
    const float MinSpawnDelay = 1;
    const float MaxSpawnDelay = 2;
      
    // spawn location support

    float SpawnBorderSize = 100;
    static float minSpawnX;
    static float maxSpawnX;
    static float minSpawnY;
    static float maxSpawnY;

    // Start is called before the first frame update
    void Start()
    {
        // save spawn boundaries for efficiency
        minSpawnX = Screen.width;
        maxSpawnX = minSpawnX + SpawnBorderSize;
        minSpawnY = Screen.height;
        maxSpawnY = minSpawnY + SpawnBorderSize;

        StartCoroutine(SpawnRandomAsteroids());
    }

    void SpawnAsteroid()
    {
        // Gameobject spawn support
        List<GameObject> asteroidsList = new List<GameObject>();

        asteroidsList.Add(AsteroidOnePrefab);
        asteroidsList.Add(AsteroidTwoPrefab);
        asteroidsList.Add(AsteroidThreePrefab);
        asteroidsList.Add(AsteroidFourPrefab);
        asteroidsList.Add(AsteroidFivePrefab);

        GameObject randomAsteroids = asteroidsList[Random.Range(0, 5)];

        // generate random location and create new asteroids
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX), Random.Range(minSpawnY, maxSpawnY), -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject asteroids = Instantiate(randomAsteroids) as GameObject;
        asteroids.transform.position = worldLocation;
        asteroids.transform.RotateAround(Vector3.zero, new Vector3(0, 0, 1), Random.Range(0, 360));
        asteroids.GetComponent<Rigidbody2D>().AddForce(new Vector3(Random.Range(-8, 8), 0, 0) - asteroids.transform.position * Random.Range(0.0f, 0.8f), ForceMode2D.Impulse);
    }

    IEnumerator SpawnRandomAsteroids()
    {
        yield return new WaitForSeconds(2f);

        int index = Random.Range(0, 5);

        SpawnAsteroid();
       
        StartCoroutine(SpawnRandomAsteroids());
    }

}
