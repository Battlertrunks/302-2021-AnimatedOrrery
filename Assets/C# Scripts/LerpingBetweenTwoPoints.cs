using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpingBetweenTwoPoints : MonoBehaviour
{
    public Transform cameraPos;
    public TargetObject planetOrMoonTarget;
    public static float percent = 0;
    // Update is called once per frame
    void Start() {

    }
    void LateUpdate()
    {
        TargetObject planetOrMoonTarget = GetComponent<TargetObject>();
        transform.position = OrbitalMathAnim.LerpFunc(cameraPos.position, planetOrMoonTarget.targetToLock.transform.position, percent);
    }
}
