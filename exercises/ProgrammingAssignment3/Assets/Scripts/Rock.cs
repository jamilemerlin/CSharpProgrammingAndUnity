using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // apply impulse force to get game object moving
        const float MinImpulseForce = 2f;
        const float MaxImpulseForce = 6f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
    }

    /// <summary>
    /// Destroy the rocks
    /// </summary>
    void Destroy()
    {
        Destroy(gameObject);
    }

    /// <summary>
    /// when the rock goes out of the screen, it will be destroy
    /// </summary>
    void OnBecameInvisible()
    {
        this.Destroy();
    }


    /// <summary>
    /// Called on a colision
    /// </summary>
    void OnCollisionEnter2D(Collision2D coll)
    {
        // when the rock hit another rock, it will be destroy
        if (coll.gameObject.tag == "RockPrefab")
        {
            this.Destroy();
        }
    }

    void Update()
    {
   
    }

}
