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

    // movement support
    const float MoveUnitsPerSecond = 5;

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
        // move based on input
        Vector3 position = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (horizontalInput != 0)
        {
            position.x += horizontalInput * MoveUnitsPerSecond * Time.deltaTime;
        }
        if (verticalInput != 0)
        {
            position.y += verticalInput * MoveUnitsPerSecond * Time.deltaTime;
        }

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
