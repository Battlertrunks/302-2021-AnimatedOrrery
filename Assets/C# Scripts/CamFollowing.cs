using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowing : MonoBehaviour
{
    public Transform targetToSlide;

    void Update()
    {
        transform.position = OrbitalMathAnim.SlidingAction(transform.position, targetToSlide.position, 0.1f);
    }
}
