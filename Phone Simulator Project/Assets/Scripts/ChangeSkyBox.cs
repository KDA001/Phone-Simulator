using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class ChangeSkyBox : MonoBehaviour
{
    public void SkyBox_1(Material skyBoxMaterial)
    {
        RenderSettings.skybox = skyBoxMaterial;
    }
    public void SkyBox_Reflection(Cubemap cubemap_)
    {
        RenderSettings.customReflection = cubemap_;
    }
}
