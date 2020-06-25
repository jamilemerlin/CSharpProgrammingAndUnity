using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the game object
/// </summary>
public class Jumper : MonoBehaviour
{

    //  jump  location  support 
    const float maxX = 5;
    const float minX = -5;
    const float maxY = 2.5f;
    const float minY = -2.5f;

    //  timer  support
    const float TotalJumpDelaySeconds = 1;
    float elapsedJumpDelaySeconds = 0;

    void Update()
    {
        //  update  timer  and  check  if  it's done
        elapsedJumpDelaySeconds += Time.deltaTime;

        if (elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            transform.position = new Vector3(Random.Range(maxX, minX), Random.Range(maxY, minY), 0);
        }
    }
}
