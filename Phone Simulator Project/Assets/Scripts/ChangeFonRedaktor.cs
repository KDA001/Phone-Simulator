using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFonRedaktor : MonoBehaviour
{
    public Camera _camera;
    public Material _materialSkyBox;
    public Cubemap _cubeMapSkyBox;

    public Material _materialDefuatSkyBox;
    public Cubemap _cubeMapDefuatSkyBox;
    public void ChangeOn()
    {
        _camera.clearFlags = CameraClearFlags.Skybox;

        RenderSettings.skybox = _materialSkyBox;
        RenderSettings.customReflection = _cubeMapSkyBox;
    }

    public void ChangeOff()
    {
        _camera.clearFlags = CameraClearFlags.SolidColor;

        RenderSettings.skybox = _materialDefuatSkyBox;
        RenderSettings.customReflection = _cubeMapDefuatSkyBox;
    }
}
