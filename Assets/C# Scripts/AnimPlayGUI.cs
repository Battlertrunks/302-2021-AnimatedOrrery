using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CamLerp))]
public class AnimPlayGUI : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        CamLerp animPlay = (CamLerp) target;

        if (GUILayout.Button("PLAYIT"))
        {
            animPlay.PlayAnim();
        }
    }
}
