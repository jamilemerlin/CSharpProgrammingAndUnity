using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Makes the game object talk
/// </summary>
public class Talker : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        // temporary debugging code
        Vector3 position = transform.position;
        position.x = 1;

        // the first phrase
        print("HI, I'm your best friend!");

      
    }

}
