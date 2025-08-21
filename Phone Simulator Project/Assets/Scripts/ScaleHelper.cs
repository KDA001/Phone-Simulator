using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleHelper : MonoBehaviour
{
    public GameObject Phone;
    public GameObject Display;

    public Slider SizeSlider;
    public Slider WidthSlider;
    public Slider DisplaySlider;

    public void CorpusSize()
    {
        Phone.transform.localScale = new Vector3(Phone.transform.localScale.x, SizeSlider.value, SizeSlider.value);
    }

    public void CorpusWidth()
    {
        Phone.transform.localScale = new Vector3(WidthSlider.value, Phone.transform.localScale.y, Phone.transform.localScale.z);
    }
    public void DisplayScale()
    {
        Display.transform.localScale = new Vector3(DisplaySlider.value, DisplaySlider.value, Display.transform.localScale.z);
    }

}
