using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Data_Now : MonoBehaviour
{
    private TextMeshProUGUI TMPro_Text;
    public string[] Months;
    private void Start()
    {

        TMPro_Text = GetComponent<TextMeshProUGUI>();
    }
    private void FixedUpdate()
    {
        var currentDate = System.DateTime.Now;
        for(int i = 0; i < Months.Length; i++)
        {
            TMPro_Text.text = Months[currentDate.Month - 1].ToString() + ", " + currentDate.Day.ToString() + " day";
            //TMPro_Text.text = currentDate.Month.ToString() + "," + currentDate.Day.ToString();
        }
      
    }
}
