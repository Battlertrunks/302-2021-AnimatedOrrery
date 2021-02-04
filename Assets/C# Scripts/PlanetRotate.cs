using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    public float rotateSpeed = 0;

    void Update()
    {
        transform.Rotate(0, rotateSpeed * HUDTimeSlider.timeScale, 0);
    }
}
