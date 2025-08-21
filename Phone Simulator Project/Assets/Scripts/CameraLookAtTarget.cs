using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAtTarget : MonoBehaviour
{
    public Transform _transformPhone;
    public float speed = 2f;
    private Transform _transform;
    private Vector3 NewTarget;
    private void Start()
    {
        _transform = GetComponent<Transform>();
    }
    void Update()
    {
        //NewTarget = Vector3.Lerp(NewTarget, Phone.transform.position, Time.deltaTime * speed);
        //_transform.LookAt(NewTarget);
    }
    private void LateUpdate()
    {
        NewTarget = Vector3.Lerp(NewTarget, _transformPhone.position, Time.deltaTime * speed);
        _transform.LookAt(NewTarget);
    }
}
