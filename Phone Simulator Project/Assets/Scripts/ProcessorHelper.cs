using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessorHelper : MonoBehaviour
{
    public Material ProcessorMaterial;

    public void ProcessorChange(Texture pics)
    {
        ProcessorMaterial.mainTexture = pics;
        ProcessorMaterial.SetTexture("_EmissionMap", pics);
    }

    public void Intel(Texture pics)
    {
        ProcessorMaterial.mainTexture = pics;
        ProcessorMaterial.SetTexture("_EmissionMap", pics);
    }
    public void AMD(Texture pics)
    {
        ProcessorMaterial.mainTexture = pics;
        ProcessorMaterial.SetTexture("_EmissionMap", pics);
    }
    public void Lapple(Texture pics)
    {
        ProcessorMaterial.mainTexture = pics;
        ProcessorMaterial.SetTexture("_EmissionMap", pics);
    }
    public void Quwalcom(Texture pics)
    {
        ProcessorMaterial.mainTexture = pics;
        ProcessorMaterial.SetTexture("_EmissionMap", pics);
    }
}
