using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OrbitPath
{
    public static void DrawOrbitCircle(this GameObject planet, float orbitRadius, float lineStroke)
    {
        Color nameColor1 = Color.white;
        Color nameColor2 = new Color(1, 1, 1, .2f);

        int parts = 360;
        LineRenderer line = planet.AddComponent<LineRenderer>();

        line.useWorldSpace = false;
        line.endWidth = lineStroke;
        line.startWidth = lineStroke;
        line.positionCount = parts + 1;
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.SetColors(nameColor2, nameColor2);
        

        int count = parts + 1;
        Vector3[] part = new Vector3[count];

        for(int t = 0; t < count; t++)
        {
            float radius = Mathf.Deg2Rad * (t * 360f / parts);
            part[t] = new Vector3(Mathf.Sin(radius) * orbitRadius, 0, Mathf.Cos(radius) * orbitRadius);
        }

        line.SetPositions(part);
    }
}
