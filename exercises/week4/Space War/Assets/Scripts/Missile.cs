using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public static Missile instance;  // Configured in the Prefab (UI)
    public float velocityMissile;  // Configured in the Prefab (UI)
    private Rigidbody2D rbMissile;
    Vector2 thrustDirection = new Vector2();
    

    private void Start()
    {
        rbMissile = GetComponent<Rigidbody2D>();

        float RotationZ = (transform.eulerAngles.z + 90) * Mathf.Deg2Rad;
        thrustDirection.x = Mathf.Cos(RotationZ);
        thrustDirection.y = Mathf.Sin(RotationZ);
        rbMissile.velocity = thrustDirection * velocityMissile;
    }

    // Destroy gameobject when it go out the screen
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
