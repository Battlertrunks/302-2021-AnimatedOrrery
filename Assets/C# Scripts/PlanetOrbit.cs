using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetOrbit : MonoBehaviour
{
    /// <summary>
    /// PLANETORBIT SETS THE ORBIT ORBIT SPEED, ITS TARGET TO ORBIT AND HOW FAR, AND CALLS THE DRAWORBITCIRCLE CLASS
    /// </summary>

    // Declaring/initializing floats and getting the target to revolve around transform
    public float revolveRadius = 0;
    public float time = 0;
    public Transform revolveAroundObject;

    public float revolutions = 0;

    public float orbitSpeed = 1;

    [Range(0, 6.285f)]
    public float orbitPosition = 0;

    public static List<GameObject> planetsAndMoons = new List<GameObject>(); // A list of the moons and planets in the system

    void Start()
    {
        planetsAndMoons.Add(gameObject); // Adds all of the planets and moons on the list

        GameObject createLine = new GameObject { name = "OrbitCircle" };
        if(this.gameObject.tag == "Moons") // If the gameobjects tag is "Moons" it will create their orbit path with the planet they are revolving around
        {
            createLine.DrawOrbitCircle(revolveRadius, 1f);
            createLine.transform.SetParent(revolveAroundObject);
            createLine.transform.position = revolveAroundObject.position;
        }
        else
            createLine.DrawOrbitCircle(revolveRadius, 15f); // If planets are revolving around the sun
    }


    void Update()
    {
        time = time + Time.deltaTime * orbitSpeed * HUDTimeSlider.timeScale; // This controls the time. HUDTimeSlider.timeScale makes the time rewind, fast forward, pause, and resume.

        Vector3 PlanetOrbitVectorXZ = OrbitalMathAnim.OrbitAroundTarget(revolveRadius, time, orbitPosition);
        transform.position = revolveAroundObject.position + PlanetOrbitVectorXZ; // calulates the position for the planets and moons during their animation
    }
}
