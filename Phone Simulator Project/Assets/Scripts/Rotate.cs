using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform Phone;
    private Quaternion currentAxis;
    public Quaternion changeAxis;
    public bool isRotate = false;
    public float velocityRotate = 2f;

    public Quaternion Axis_0;
    public Quaternion Axis_90;
    public Quaternion Axis_180;
    void Update()
    {
        CurrentAxis();
    }

    void CurrentAxis()
    {
        if (isRotate)
        {
            Phone.localRotation = Quaternion.RotateTowards(Phone.localRotation, currentAxis, velocityRotate * Time.deltaTime);
            if (Phone.localRotation == currentAxis)
                isRotate = false;
        }
    }

    public void ChangeAxis()
    {
        currentAxis = changeAxis;
        isRotate = true;
    }

    public void AxisForward()
    {
        currentAxis = Axis_0;
        isRotate = true;
    }

    public void AxisSide()
    {
        currentAxis = Axis_90;
        isRotate = true;
    }

    public void AxisBack()
    {
        currentAxis = Axis_180;
        isRotate = true;
    }
}
