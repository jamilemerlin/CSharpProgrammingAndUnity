using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    // test object
    Timer timer;

    // time measurement
    float startTime;
    void Start()
    {
        // create and run timer
        timer = gameObject.AddComponent<Timer>()
        ;
        timer.Duration = 3;
        timer.Run();

        // save start timer
        startTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        // check for timer just finished
        if (timer.Finished)
        {
            float elapsedTime = Time.time - startTime;
            print("Timer ran for " + elapsedTime + " seconds.");

            // save start time and restart timer
            startTime = Time.time;
            timer.Run();
        }
    }
}
