using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBehavior : MonoBehaviour
{

    [Range(-10f, 10f)]
    public float timeSpeed = 0;


    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    public void FastForward()
    {
        Time.timeScale = 3;
    }

    public void OnClick()
    {
        foreach(GameObject PlanetOrbit in PlanetOrbit.planetsAndMoons)
        {
            PlanetOrbit.GetComponent<PlanetOrbit>().orbitSpeed = PlanetOrbit.GetComponent<PlanetOrbit>().orbitSpeed * -1;
        }
    }


}
