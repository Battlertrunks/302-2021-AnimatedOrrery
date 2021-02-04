using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDTimeSlider : MonoBehaviour
{
    /// <summary>
    /// MANIPULATES TIME WHEN THE PLAYER EDITS THE TIME SCALE SLIDER AND PAUSE/RESUME BUTTTON
    /// </summary>
    
    // initializing the starting time of the application
    public static float timeScale = .01f;
    public Text textTimeNoti; // Getting time text
    public Slider sliderUI; // Getting Slider 
    public bool paused = true;  
    private float pauseValue = 1;
    // Saves the most recent time before the player pauses 
    private float savedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Calling SliderTimeUpdater and sending an argument as the beginning time
        SliderTimeUpdater(.01f);
    }

    // This function assigns the time to timeScale and than converts it into a string for the textTimeNoti to show the user
    public void SliderTimeUpdater(float amount)
    {
            timeScale = amount * pauseValue;
            textTimeNoti.text = System.Math.Round(timeScale, 2).ToString();
    }

    // Pauses the game when the player press the pause/resume button
    public void PausedOrNot()
    {
        if (paused)
        {
            savedTime = timeScale;
            timeScale = 0;
            paused = false;

        }
        else
        {
            timeScale = savedTime;
            savedTime = 0;
            paused = true;
        }
    }
}
