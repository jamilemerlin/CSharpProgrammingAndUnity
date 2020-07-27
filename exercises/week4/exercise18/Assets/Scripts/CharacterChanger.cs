using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChanger : MonoBehaviour
{
    [SerializeField]
    GameObject BurningTeddyPrefab;
    [SerializeField]
    GameObject TeddyBearPrefab;

    // need for a location of new character
    GameObject currentCharacter;

    // first frame input support
    bool previousFrameChangeCharacterInput = false;

    // identify the character
    bool teddyIsBurning = false;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        currentCharacter = Instantiate<GameObject>(
            TeddyBearPrefab, Vector3.zero, Quaternion.identity);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        //change character on left mouse buttom 
        if (Input.GetAxis("ChangeCharacter") > 0)
        {
            // only change character on first input frame
            if (!previousFrameChangeCharacterInput)
            {
                previousFrameChangeCharacterInput = true;
                // save current position and destroy current character
                Vector3 position = currentCharacter.transform.position;
                Destroy(currentCharacter);

                // selecting the new character
                this.teddyIsBurning = !this.teddyIsBurning;
                if (this.teddyIsBurning)
                {
                    currentCharacter = Instantiate(
                        BurningTeddyPrefab, position, Quaternion.identity);
                }
                else
                {
                    currentCharacter = Instantiate(
                        TeddyBearPrefab, position, Quaternion.identity);
                }
            }
        }
        else
        {
            // no change character input
            previousFrameChangeCharacterInput = false;
        }
    }
}
