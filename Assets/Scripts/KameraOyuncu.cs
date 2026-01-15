using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraOyuncu : MonoBehaviour {
    public enum RotationAxis
    {
        MouseX=1,
        MouseY=2
    }
    public RotationAxis MouseHareket = RotationAxis.MouseX;
    public float HassasYatay = 10.0F;
    public float MinYatay = -20.0F;
    public float MaxYatay = 43.0F;
    public float HassasDikey = 10.0F;
    public float RotasyonX = 0.0F;
    void Update()
    {
        if (MouseHareket == RotationAxis.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * HassasYatay, 0);
        }
        else if (MouseHareket == RotationAxis.MouseY)
        {
            RotasyonX -= Input.GetAxis("Mouse Y") * HassasDikey;
            RotasyonX = Mathf.Clamp(RotasyonX, MinYatay, MaxYatay);
            float RotasyonY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(RotasyonX, RotasyonY, 0);
        }
    }
}
