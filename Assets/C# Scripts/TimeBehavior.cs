using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// THIS WAS A TEMPORARY TIME MANIPULATOR THAT IS NOT BEING USED AND NOT ATTACHED TO ANYTHING.
/// </summary>

public class TimeBehavior : MonoBehaviour
{
    // Added a range that the player can fast forward or rewind with the float variable
    [Range(-10f, 10f)]
    public float timeSpeed = 0;

    // Pauses the game
    public void Pause()
    {
        Time.timeScale = 0;
    }

    // Resumes the game when paused or rewinded/fast-forwarded
    public void Resume()
    {
        Time.timeScale = 1;
    }

    // Fast forwards the game
    public void FastForward()
    {
        Time.timeScale = 3;
    }

    // Rewinds the planets
    public void OnClick()
    {
        foreach(GameObject PlanetOrbit in PlanetOrbit.planetsAndMoons)
        {
            PlanetOrbit.GetComponent<PlanetOrbit>().orbitSpeed = PlanetOrbit.GetComponent<PlanetOrbit>().orbitSpeed * -1;
        }
    }


}
