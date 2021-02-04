using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    /// <summary>
    /// THE TARGETOBJECT MAKES THE CAMERA'S TARGET GO TO DIFFERENT PLANETS OR MOONS WHEN THE PLAYER CLICKS ON ONE OF THE PLANET BUTTONS AND SETS THE 
    /// CAMERA'S MAX AND MIN ZOOM
    /// </summary>

    // Getting the GameObject to target to and initializing the starting values when the game loads
    public GameObject targetToLock;
    public float p = .5f;
    public static float distanceZoomMin = 15000;
    public static float distanceZoomMax = 21000;

    void Update()
    {
        // This updates to cause a slide like effect when the player switches to a different planet/moon, zooms in or out, and rotates with right mouse button.
        transform.position = OrbitalMathAnim.SlidingEffect(transform.position, targetToLock.transform.position, p);
    }

    /// <summary>
    /// These are buttons that the player can click and the camera will go to and set the max and min zoom distance
    /// </summary>
    public void GalaxyView()
    {
        targetToLock = GameObject.Find("/Sun (Main Center)");
        distanceZoomMin = 15000;
        distanceZoomMax = 21000;
    }

    public void SunView()
    {
        targetToLock = GameObject.Find("/Sun (Main Center)");
        distanceZoomMin = 675;
        distanceZoomMax = 2000;
    }

    public void MercuryView()
    {
        targetToLock = GameObject.Find("/Mercury");
        distanceZoomMin = 5;
        distanceZoomMax = 55;
    }

    public void VenusView()
    {
        targetToLock = GameObject.Find("/Venus");
        distanceZoomMin = 9;
        distanceZoomMax = 100;
    }

    public void EarthView()
    {
        targetToLock = GameObject.Find("/Earth");
        distanceZoomMin = 8;
        distanceZoomMax = 100;
    }

    public void MarsView()
    {
        targetToLock = GameObject.Find("/Mars");
        distanceZoomMin = 5;
        distanceZoomMax = 100;
    }

    public void Jupitar()
    {
        targetToLock = GameObject.Find("/Jupiter");
        distanceZoomMin = 100;
        distanceZoomMax = 350;
    }

    public void SaturnView()
    {
        targetToLock = GameObject.Find("/Saturn");
        distanceZoomMin = 61;
        distanceZoomMax = 350;
    }

    public void UranusView()
    {
        targetToLock = GameObject.Find("/Uranus");
        distanceZoomMin = 35;
        distanceZoomMax = 350;
    }

    public void NeptuneView()
    {
        targetToLock = GameObject.Find("/Neptune");
        distanceZoomMin = 25;
        distanceZoomMax = 350;
    }

    // Moons camera lock and distance of Zoom limit
    public void EarthMoon()
    {
        targetToLock = GameObject.Find("/Earth/Earth's Moon");
        distanceZoomMin = 3;
        distanceZoomMax = 90;
    }
    
    public void Deimos()
    {
        targetToLock = GameObject.Find("/Mars/Deimos");
        distanceZoomMin = 0.5f;
        distanceZoomMax = 50;
    }
    public void Phobos()
    {
        targetToLock = GameObject.Find("/Mars/Phobos");
        distanceZoomMin = 0.5f;
        distanceZoomMax = 50;
    }
   
    public void Europa()
    {
        targetToLock = GameObject.Find("/Jupiter/Europa");
        distanceZoomMin = 2;
        distanceZoomMax = 50;
    }
   
    public void Ganymede()
    {
        targetToLock = GameObject.Find("/Jupiter/Ganymede");
        distanceZoomMin = 5;
        distanceZoomMax = 50;
    }
    
    public void Tethys()
    {
        targetToLock = GameObject.Find("/Saturn/Tethys");
        distanceZoomMin = 2;
        distanceZoomMax = 50;
    }

    public void Titan()
    {
        targetToLock = GameObject.Find("/Saturn/Titan");
        distanceZoomMin = 4;
        distanceZoomMax = 50;
    }
    public void Titania()
    {
        targetToLock = GameObject.Find("/Uranus/Titania");
        distanceZoomMin = 2.5f;
        distanceZoomMax = 50;
    }
}
