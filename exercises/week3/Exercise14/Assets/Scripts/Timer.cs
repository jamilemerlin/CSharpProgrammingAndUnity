using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A timer
/// </summary>

public class Timer : MonoBehaviour
{

    // timer duration
    float totalseconds = 0;

    // timer execution
    float elapsedSconds = 0;
    bool running = false;

    // support for Finished property
    bool started = false;

    /// <summary>
	/// Sets the duration of the timer
	/// The duration can only be set if the timer isn't currently running
	/// </summary>
	/// <value>duration</value>
    public float Duration
    {
        set
        {
            if (!running)
            {
                totalseconds = value;
            }
        }
    }

    /// <summary>
	/// Gets whether or not the timer has finished running
	/// This property returns false if the timer has never been started
	/// </summary>
	/// <value>true if finished; otherwise, false.</value>
    public bool Finished
    {
        get { return started && !running; }
    }

    /// <summary>
	/// Gets whether or not the timer is currently running
	/// </summary>
	/// <value>true if running; otherwise, false.</value>
    public bool Running
    {
        get { return running; }
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if (running)
        {
            elapsedSconds += Time.deltaTime;
            if (elapsedSconds >= totalseconds)
            {
                running = false;
            }
        }

    }

    /// <summary>
	/// Runs the timer
	/// Because a timer of 0 duration doesn't really make sense,
	/// the timer only runs if the total seconds is larger than 0
	/// This also makes sure the consumer of the class has actually 
	/// set the duration to something higher than 0
	/// </summary>
    public void Run()
    {
        // run with a valid duration
        if (totalseconds > 0)
        {
            running = true;
            started = true;
            elapsedSconds = 0;
        }
    }
}
