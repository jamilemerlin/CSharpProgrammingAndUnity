using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will shrink and grow the game object over time.
/// </summary>
public class Resizer : MonoBehaviour
{
    // fields for timer support
    const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    // fields for resizing control
    const float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;


    
    void Update()
    {
        // resize the game object
        Vector3 newScale = transform.localScale;
        newScale.x += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        newScale.y += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        transform.localScale = newScale;

        // update timer and check if it's done
        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;
        }
    }
}
