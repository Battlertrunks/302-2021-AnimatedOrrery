using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    public GameObject targetToLock;
    public float p = .5f;
    public static float distanceZoomMin = 675;
    public static float distanceZoomMax = 2000;

    void Update()
    {
        transform.position = OrbitalMathAnim.SlidingEffect(transform.position, targetToLock.transform.position, p);
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
}
