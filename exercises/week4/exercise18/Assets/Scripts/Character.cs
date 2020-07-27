﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// character moviment
/// </summary>
public class Character : MonoBehaviour
{
    // save for efficiency
    float colliderHalfWidth;
    float colliderHalfHeight;

    // Start is called before the first frame update
    void Start()
    {
        // save for efficiency
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        colliderHalfWidth = collider.size.x / 2;
        colliderHalfHeight = collider.size.y / 2;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // convert a mouse position to world position
        Vector3 position = Input.mousePosition;
        position.z = -Camera.main.transform.position.z;
        position = Camera.main.ScreenToWorldPoint(position);

        // move to mouse position
        transform.position = position;
        ClampInScreen();
    }

    /// <summary>
    /// Clamos the character in the screen
    /// </summary>
    void ClampInScreen()
    {
        // clamp position is necessary
        Vector3 position = transform.position;
        if (position.x - colliderHalfWidth < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenLeft + colliderHalfWidth;
        }
        else if (position.x + colliderHalfWidth > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenRight - colliderHalfWidth;
        }

        if (position.y + colliderHalfHeight > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenTop - colliderHalfHeight;
        }
        else if (position.y - colliderHalfHeight < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenBottom + colliderHalfHeight;
        }
        transform.position = position;
    }
}
