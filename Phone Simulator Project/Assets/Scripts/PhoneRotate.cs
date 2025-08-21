using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneRotate : MonoBehaviour
{
    private float mouseX;
    public Transform Phone;

    public float sensetivyMouse = 200f;
    float xRotation = 0f;

    private PhoneRotate _phoneRotate;
    private void Update()
    {
        
    }
    private void Awake()
    {
        _phoneRotate = GetComponent<PhoneRotate>();
    }

    private void OnMouseDrag()
    {
        if (_phoneRotate.enabled)
        {
            mouseX = Input.GetAxis("Mouse X") * sensetivyMouse;
            Phone.Rotate(new Vector3(0, mouseX, 0));
            //Phone.Rotate(new Vector3(0, mouseX * Time.deltaTime, 0));
        }
    }
}
