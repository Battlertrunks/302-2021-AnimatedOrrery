using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    /// <summary>
    /// THIS MONOBEHAVIOR MAKES THE PLANETS AND MOONS ROTATE
    /// </summary>

    // Initializing a float that can be set a variety of speeds
    public float rotateSpeed = 0;

    void Update()
    {
        // The rotation speed is calulated with the timeScale from HudTimeSlider
        transform.Rotate(0, rotateSpeed * HUDTimeSlider.timeScale, 0);
    }
}
