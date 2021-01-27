using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUI : MonoBehaviour
{
    public Camera cam;

    public Image infoBox;

    void Update()
    {
        //Vector3 positionOfObject = cam.WorldToScreenPoint(this.transform.position);
       // infoBox.transform.position = positionOfObject;
        //Debug.Log(positionOfObject.x);
    }
}

