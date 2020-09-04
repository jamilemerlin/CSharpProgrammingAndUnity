using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get the asteroid moving
        /*GetComponent<Rigidbody2D>().AddForce(
            new Vector2(5, 0),
            ForceMode2D.Impulse);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
