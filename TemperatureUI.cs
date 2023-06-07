using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature;
    public TextMeshProUGUI temperatureText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float roundTemperature = Mathf.Round(temperature.temperatureCurrent * 10.0f) * 0.1f;
        temperatureText.text = roundTemperature.ToString();
    }
}
