using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// the main ship
/// </summary>
public class Ship : MonoBehaviour
{
    // fields for thrust and rotation support
    Rigidbody2D rigidbodyShip;
    Vector2 thrustDirection = new Vector2(0, 1);
    const float ThrustForce = 15;
    const float RotateDegreesPerSecond = 120;


    // screen support
    float circleCollider;

    // Start for the initialization
    void Start()
    {
        rigidbodyShip = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Rotate");
        if (rotation != 0)
        {
            // calculate rotation amount and apply rotation 
            float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;
            if (rotation < 0)
            {
                rotationAmount *= -1;
            }

            transform.Rotate(Vector3.forward, rotationAmount * -1);

            // change thrust direction to match ship rotation
            float RotationZ = (transform.eulerAngles.z + 90) * Mathf.Deg2Rad;
            thrustDirection.x = Mathf.Cos(RotationZ);
            thrustDirection.y = Mathf.Sin(RotationZ);
        }
    }

    void FixedUpdate()
    {
        // thrust as appropriate
        if (Input.GetAxis("Thrust") != 0)
        {
            rigidbodyShip.AddForce(ThrustForce * thrustDirection, ForceMode2D.Force);
        }
    }


    /// <summary>
    /// Called when the game object becomes invisible to the camera
    /// </summary>
    void OnBecameInvisible()
    {
        Vector2 position = transform.position;

        // check left, right edges
        if (position.x < ScreenUtils.ScreenLeft || position.x  > ScreenUtils.ScreenRight)
        {
            position.x *= -1;
        }

        // top, and bottom edges
        if (position.y > ScreenUtils.ScreenTop || position.y < ScreenUtils.ScreenBottom)
        {
            position.y *= -1;
        }

        transform.position = position;
    }
}
