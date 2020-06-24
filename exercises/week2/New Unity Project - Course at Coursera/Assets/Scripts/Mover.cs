using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Moves the game object
/// </summary>
public class Mover : MonoBehaviour
{
    /// <summary>
    /// use this for inicialization
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        // get the game object moving
        Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
        
    }
}
