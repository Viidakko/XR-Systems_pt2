using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class ZoomShaderScreenpos : MonoBehaviour
{
    [SerializeField] private Material material;
    void Update()
    {
        Vector3 screenPixels = Camera.main.ScreenToWorldPoint(transform.position);
        screenPixels = new Vector3(screenPixels.x / Screen.width, screenPixels.y / Screen.height, screenPixels.z);

        material.SetVector("_ObjectScreenPosition", screenPixels);
    }
}
