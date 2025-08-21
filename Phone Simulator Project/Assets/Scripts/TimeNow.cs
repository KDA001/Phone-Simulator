using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeNow : MonoBehaviour
{
    private TextMeshProUGUI TMPro_Text;
    private void Start()
    {
       
        TMPro_Text = GetComponent<TextMeshProUGUI>();
    }
    private void FixedUpdate()
    {
        var currentDate = System.DateTime.Now;
        TMPro_Text.text = currentDate.Hour.ToString() + ":" + currentDate.Minute.ToString();
    }
}
