using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public float revolveRadius = 0;
    private float time = 0;
    public Transform revolveAroundObject;

    [Range(0, 10f)]
    public float orbitSpeed = 1;

    [Range(0, 6.285f)]
    public float orbitPosition = 0;

    void Start()
    {
     
    }


    void Update()
    {
        time = time + Time.deltaTime * orbitSpeed;

        Vector3 PlanetOrbitVectorXZ = OrbitalMathAnim.OrbitAroundTarget(revolveRadius, time, orbitPosition);
        transform.position = revolveAroundObject.position + PlanetOrbitVectorXZ;


    }
}
