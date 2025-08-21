using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Battery : MonoBehaviour
{
    private Image BatteryImage;
    private TextMeshProUGUI BatteryText;

    private int Charge;
    private void Start()
    {

        BatteryImage = GetComponent<Image>();
        BatteryText = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        Charge = Mathf.RoundToInt(SystemInfo.batteryLevel * 100);

        BatteryText.text = Charge.ToString();

        if(Charge <= 30 && Charge > 15)
        {
            BatteryImage.color = Color.yellow;
        }
        else if(Charge <= 15)
        {
            BatteryImage.color = Color.red;
        }
        else
        {
            BatteryImage.color = Color.white;
        }
    }
}
