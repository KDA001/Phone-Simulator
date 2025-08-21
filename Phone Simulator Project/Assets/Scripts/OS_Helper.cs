using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OS_Helper : MonoBehaviour
{

    public Material OS_Material;
    public Texture _textureAndroid;
    public Texture _textureIOS;
    public void Android()
    {
        OS_Material.mainTexture = _textureAndroid;
        OS_Material.SetTexture("_EmissionMap", _textureAndroid);
    }
    public void IOS()
    {
        OS_Material.mainTexture = _textureIOS;
        OS_Material.SetTexture("_EmissionMap", _textureIOS);
    }
}
