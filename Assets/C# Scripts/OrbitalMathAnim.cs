using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OrbitalMathAnim
{

    public static Vector3 OrbitAroundTarget(float revolveRadius, float time, float orbitPosition)
    {
        Vector3 distance = new Vector3();
        distance.x = Mathf.Sin(time + orbitPosition) * revolveRadius;
        distance.z = Mathf.Cos(time + orbitPosition) * revolveRadius;
        
        return distance;
    }

    public static float LerpFunc(float minimum, float maximum, float percentage, bool ExtrapAllowed = true)
    {
        if (!ExtrapAllowed)
        {
            if (percentage < 0)
                percentage = 0;
            if (percentage > 0.99f)
                percentage = 0.98f;
        }
        return (maximum - minimum) * percentage + minimum;
    }

    public static Vector3 LerpFunc(Vector3 minimum, Vector3 maximum, float percentage, bool ExtrapAllowed = true)
    {
        if (!ExtrapAllowed)
        {
            if (percentage < 0)
                percentage = 0;
            if (percentage > 0.99f)
                percentage = 0.99f;
        }
        return (maximum - minimum) * percentage + minimum;
    }

    public static float SlidingAction(float currentPosition, float targetToGo, float percentLeft)
    {
        float percent = Mathf.Pow(percentLeft, Time.deltaTime);
        return OrbitalMathAnim.LerpFunc(currentPosition, targetToGo, percent);
    }

    public static Vector3 SlidingAction(Vector3 currentPosition, Vector3 targetToGo, float percentLeft)
    {
        float percent = Mathf.Pow(percentLeft, Time.deltaTime);
        return OrbitalMathAnim.LerpFunc(currentPosition, targetToGo, percent);
    }
}
