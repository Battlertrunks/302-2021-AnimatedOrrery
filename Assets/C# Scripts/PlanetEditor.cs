using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PlanetOrbit))]
public class PlanetEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        PlanetOrbit reverseEditor = (PlanetOrbit) target;

        if (GUILayout.Button("REWIND", GUILayout.Width(100)))
        {
            reverseEditor.orbitSpeed = reverseEditor.orbitSpeed * -1;
        }
    }


}
