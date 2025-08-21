using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorHelper : MonoBehaviour
{
    public Material _materialPhone;

    public void ColorPhone()
    {
        _materialPhone.color = gameObject.GetComponent<Image>().color;
    }
}
