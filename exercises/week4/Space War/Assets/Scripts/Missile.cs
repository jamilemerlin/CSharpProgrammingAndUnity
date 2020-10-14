using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // saved to support
    public static Missile instance;
    public float velocity = 5.0f;
    private Rigidbody2D rbMissile;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rbMissile = this.GetComponent<Rigidbody2D>();
        rbMissile.velocity = rbMissile.transform.position * velocity;
        //rbMissile.AddForce(new Vector3(0.1f, 0.1f, 1 * velocity * Time.deltaTime));
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void FixedUpdate()
    {
       
    }

    // Destroy gameobject when it go out the screen
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
