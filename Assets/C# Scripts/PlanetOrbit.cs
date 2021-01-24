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
        GameObject createLine = new GameObject { name = "OrbitCircle" };
        if(this.gameObject.tag == "Moons")
        {
            createLine.DrawOrbitCircle(revolveRadius, 1f);
            createLine.transform.SetParent(revolveAroundObject);
            createLine.transform.position = revolveAroundObject.position;
        }
        else
            createLine.DrawOrbitCircle(revolveRadius, 15f);
    }


    void Update()
    {
        time = time + Time.deltaTime * orbitSpeed;

        Vector3 PlanetOrbitVectorXZ = OrbitalMathAnim.OrbitAroundTarget(revolveRadius, time, orbitPosition);
        transform.position = revolveAroundObject.position + PlanetOrbitVectorXZ;


    }
}
