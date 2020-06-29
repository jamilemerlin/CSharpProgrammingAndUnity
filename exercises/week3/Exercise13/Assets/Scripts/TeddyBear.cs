using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBear : MonoBehaviour
{
    // explosion support
    [SerializeField]
    GameObject prefabExplosion;

    // death support
    const float TeddyBearLifespanSeconds = 10;
    Timer deathTimer;

    // Start is called before the first frame update
    void Start()
    {
        // get the game object moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(direction * magnitude, ForceMode2D.Impulse);

        // create and start timer
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = TeddyBearLifespanSeconds;
        deathTimer.Run();
    }

    /// <summary>
    /// Kill TeddyBear and start explosion animation
    /// </summary>
    void Destroy()
    {
        Instantiate<GameObject>(prefabExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    /// <summary>
    /// Called on a colision
    /// </summary>
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        // only blow up when colliding with a teddy bear
        if (coll.gameObject.tag == "C4TeddyBear")
        {
            this.Destroy();
        }
    }

    void Update()
    {
        // kill Teddy bear when timer finished
        if (deathTimer.Finished)
        {
            this.Destroy();
        }
    }
}
