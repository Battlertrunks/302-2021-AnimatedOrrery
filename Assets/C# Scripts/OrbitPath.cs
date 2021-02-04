using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OrbitPath
{
    /*
        ORBITPATH CLASS IS FOR MAKING THE LINES THAT THE PLANETS AND MOONS FOLLOW
    */

    // Brings in 3 parameters to make the lines
    public static void DrawOrbitCircle(this GameObject planet, float orbitRadius, float lineStroke)
    {
        // Setting the color
        Color nameColor1 = Color.white;
        Color nameColor2 = new Color(1, 1, 1, .2f);

        // Setting the segments
        int parts = 360;
        LineRenderer line = planet.AddComponent<LineRenderer>();

        // Setting the line attributes
        line.useWorldSpace = false;
        line.endWidth = lineStroke;
        line.startWidth = lineStroke;
        line.positionCount = parts + 1;
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.SetColors(nameColor2, nameColor2);
        

        int count = parts + 1;
        Vector3[] part = new Vector3[count];

        // Using a for loop to create the lines 
        for(int t = 0; t < count; t++)
        {
            float radius = Mathf.Deg2Rad * (t * 360f / parts);
            part[t] = new Vector3(Mathf.Sin(radius) * orbitRadius, 0, Mathf.Cos(radius) * orbitRadius);
        }

        line.SetPositions(part);
    }
}
