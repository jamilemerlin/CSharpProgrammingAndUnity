using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroys C4 Teddy bears
/// </summary>
public class Destroyer : MonoBehaviour
{
    /*[SerializeField]
    GameObject prefabExplosion;

    // timer support
    Timer explodeTimer;

    void Start()
    {
        // create and start timer
        explodeTimer = gameObject.AddComponent<Timer>();
        explodeTimer.Duration = 1;
        explodeTimer.Run();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // check the timer finished
        if (explodeTimer.Finished)
        {
            explodeTimer.Run();

            // look for a C4 Teddy bear and blow up.
            GameObject teddyBear = GameObject.FindWithTag("C4TeddyBear");
            if (teddyBear != null)
            {
                Instantiate<GameObject>(prefabExplosion, teddyBear.transform.position, Quaternion.identity);
                Destroy(teddyBear);
            }
        }
    }*/
}
