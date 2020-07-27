using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// To jump the game object to the mouse location when the left mouse button is pressed.
/// </summary>
public class Jumper : MonoBehaviour
{
    // Update is called once per frame
   /* void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // convert a mouse position to world position
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            // jump to mouse position
            transform.position = position;
        }
    }*/
}
