using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OrbitalMathAnim
{
    /*
     * THIS CLASS IS FOR THE MATH OF THE ANIMATION (LERP, SLIDING, ETC)
     */

    // This function makes the planets and moons revolve around their target from using sin and cos
    public static Vector3 OrbitAroundTarget(float revolveRadius, float time, float orbitPosition)
    {
        Vector3 distance = new Vector3();
        distance.x = Mathf.Sin(time + orbitPosition) * revolveRadius;
        distance.z = Mathf.Cos(time + orbitPosition) * revolveRadius;
        
        return distance;
    }

    // These functions calulate the lerp
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

    // Calculates the Sliding Effect when called
    public static float SlidingEffect(float currentPos, float theTarget, float percentageLeft)
    {
        float percent = 1 - Mathf.Pow(percentageLeft, Time.deltaTime);
        return OrbitalMathAnim.LerpFunc(currentPos, theTarget, percent); // Uses the lerpFunc to to calculate the lerp, then sends back the value
    }

    public static Vector3 SlidingEffect(Vector3 currentPos, Vector3 theTarget, float percentageLeft)
    {
        float percent = 1 - Mathf.Pow(percentageLeft, Time.deltaTime);
        return OrbitalMathAnim.LerpFunc(currentPos, theTarget, percent);
    }
}
