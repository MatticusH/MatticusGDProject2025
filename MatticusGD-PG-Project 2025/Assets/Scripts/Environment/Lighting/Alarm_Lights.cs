using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm_Lights : MonoBehaviour
{
    [SerializeField] Light[] alarmLights;  // Reference to the Light component
    [SerializeField] Color color1 = Color.white;  // First color (white)
    [SerializeField] Color color2 = Color.red;    // Second color (red)
    [SerializeField] float duration = 1.0f;       // Duration of the phase

    void Start()
    {
        if (alarmLights == null || alarmLights.Length == 0)
        {
            
            // Automatically get all Light components if not set
            alarmLights = GetComponentsInChildren<Light>();
        }
    }

    void Update()
    {
        if (alarmLights != null && alarmLights.Length > 0)
        {
            float t = Mathf.PingPong(Time.time / duration, 1.0f);
            Color lerpedColor = Color.Lerp(color1, color2, t);

            foreach (Light alarmLight in alarmLights)
            {
                alarmLight.color = lerpedColor;
            }
        }
    }
}
