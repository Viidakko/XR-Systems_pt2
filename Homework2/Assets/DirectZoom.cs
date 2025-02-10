using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectZoom : MonoBehaviour
{
    public Camera mainCam;
    public Transform lens;

    private void Start()
    {
        mainCam = Camera.main;
    }

    void Update()
    {
        Vector3 qazeDirection = transform.position - mainCam.transform.position;

        Quaternion lookRotation = Quaternion.LookRotation(qazeDirection);

        float roll = lens.eulerAngles.z;

        transform.rotation = Quaternion.Slerp(transform.rotation,
                                              Quaternion.Euler(lookRotation.eulerAngles.x, lookRotation.eulerAngles.y, roll),
                                              Time.deltaTime * 5f);
    }
}
