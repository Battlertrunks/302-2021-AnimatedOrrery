using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRevolving : MonoBehaviour
{

    // Getting the Yaw of the camera in degrees
    float theYaw = 0;
    float theTargetYaw = 0;

    // The pitch of the camera
    float thePitch = 0;
    float theTargetPitch = 0;

    // How far away the Camera should be
    float theDollyDistance = 1900;
    float theTargetDollyDis = 1900;

    // Mouse scroll in and out of target speed
    public float mouseScrollMultiplier = 10;

    // Mouse sensitivity for Y and X axis
    public float mouseYSensitivity = 10;
    public float mouseXSensitivity = 10;

    public float distanceLimit = 2000;

    private Camera assignedCams;

    // Start is called before the first frame update
    void Start()
    {
        // Assigning camera
        assignedCams = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // When player clicks on right mouse button
        if (Input.GetButton("Fire2"))
        {
            // Changing the pitch when player is holding right click
            float mouseAxisY = Input.GetAxis("Mouse Y");
            float mouseAxisX = Input.GetAxis("Mouse X");

            theTargetYaw += mouseAxisX * mouseXSensitivity;
            theTargetPitch += mouseAxisY * mouseYSensitivity;
        }

        // Changes the pich rotation
        theTargetPitch = Mathf.Clamp(theTargetPitch, -85, 85); // Clamping the rotation so the camera doesn't get stuck or freak out at 90 degrees

        // Easing
        thePitch = OrbitalMathAnim.SlidingEffect(thePitch, theTargetPitch, .05f);
        theYaw = OrbitalMathAnim.SlidingEffect(theYaw, theTargetYaw, .05f);

        // Rotating using Quaternion
        transform.rotation = Quaternion.Euler(thePitch, theYaw, 0);

        float scrollWheel = Input.GetAxisRaw("Mouse ScrollWheel");
        theTargetDollyDis += scrollWheel * mouseScrollMultiplier;
        theTargetDollyDis = Mathf.Clamp(theTargetDollyDis, TargetObject.distanceZoomMin, TargetObject.distanceZoomMax);

        theDollyDistance = OrbitalMathAnim.SlidingEffect(theDollyDistance, theTargetDollyDis, .05f);
        assignedCams.transform.localPosition = new Vector3(0, 0, -theDollyDistance);
    }
}
