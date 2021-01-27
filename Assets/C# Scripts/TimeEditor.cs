using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TimeBehavior))]
public class TimeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        TimeBehavior timeSetting = (TimeBehavior) target;

        if (GUILayout.Button("PAUSE"))
        {
            timeSetting.Pause();
        }

        if (GUILayout.Button("RESUME"))
        {
            timeSetting.Resume();
        }
    }
}
