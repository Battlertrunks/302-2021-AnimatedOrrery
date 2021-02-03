using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDTimeSlider : MonoBehaviour
{
    public static float timeScale = .01f;
    public Text textTimeNoti;
    public Slider sliderUI;
    public bool paused = true;
    private float pauseValue = 1;
    private float savedTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        SliderTimeUpdater(.01f);
    }

    public void SliderTimeUpdater(float amount)
    {
            timeScale = amount * pauseValue;
            textTimeNoti.text = System.Math.Round(timeScale, 2).ToString();
    }

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
