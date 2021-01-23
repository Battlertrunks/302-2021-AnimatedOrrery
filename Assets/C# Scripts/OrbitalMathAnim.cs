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
}
