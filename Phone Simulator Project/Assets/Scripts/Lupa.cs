using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lupa : MonoBehaviour
{
    public Camera _camera;
    public float speed;
    private float start;
    private float last;
    public float min;
    public float max;
    private void Start()
    {
        start = _camera.fieldOfView;
        last = _camera.fieldOfView;
    }
    private void Update()
    {
        _camera.fieldOfView = Mathf.Lerp(_camera.fieldOfView, last, speed * Time.deltaTime);
    }
    public void Plus()
    {
        start = _camera.fieldOfView;
        last = min;
    }
    public void Minus()
    {
        start = _camera.fieldOfView;
        last = max;
    }
}
