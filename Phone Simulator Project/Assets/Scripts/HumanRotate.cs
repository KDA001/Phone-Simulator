using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanRotate : MonoBehaviour
{
    private float mouseX;
    public Transform Human;

    public float sensetivyMouse = 200f;
    float xRotation = 0f;

    private HumanRotate _humanRotate;
    private void Update()
    {
        
    }
    private void Awake()
    {
        _humanRotate = GetComponent<HumanRotate>();
    }

    private void OnMouseDrag()
    {
        if (_humanRotate.enabled)
        {
            mouseX = Input.GetAxis("Mouse X") * sensetivyMouse;
            Human.Rotate(new Vector3(0, mouseX, 0));
        }
    }
}
