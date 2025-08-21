using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MarkingHelper : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public string[] newText_text;

    public void TextChange(TMP_Dropdown txt_)
    {
        txt.text = "Model: RT3749" + "\n" + "Made in " + newText_text[txt_.value];
    }

    public void _sliderTransparency(float value)
    {
        txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, value);
    }

    public void _sliderBrightness(float value)
    {
        txt.color = new Color(value, value, value, txt.color.a);
    }
}
