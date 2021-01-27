using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLerp : MonoBehaviour
{

    private bool camAnim = false;

    public GameObject startingPoint;
    public GameObject endingPoint;

    private float timeOfAnimLength;
    private float animTime = 0;

    [Range(0, 1)] public float percent = 0;

    public AnimationCurve animCurve;


    // Update is called once per frame
    void Update()
    {
        if (camAnim)
        {
            animTime += Time.deltaTime;
            percent = animTime / timeOfAnimLength;
            percent = Mathf.Clamp(percent, 0, .99f);

            float percentage = animCurve.Evaluate(percent);
            ExecuteLerp(percentage);

            if (percent >= 0.99f)
                camAnim = false;

        }
    }

    private void ExecuteLerp(float percentage)
    {
        transform.position = OrbitalMathAnim.LerpFunc(startingPoint.transform.position, endingPoint.transform.position, percentage);
    }

    private void OnValidate()
    {
        ExecuteLerp(percent);
    }

    public void PlayAnim()
    {
        camAnim = true;
        animTime = 0;
    }
}
