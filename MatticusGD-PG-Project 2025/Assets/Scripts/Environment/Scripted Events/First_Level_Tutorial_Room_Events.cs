using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_Level_Tutorial_Room_Events : MonoBehaviour
{
    [SerializeField] private GameObject[] lightGroups;
    [SerializeField] private float _alarmDelay = 5.0f;
    [SerializeField] private float _callDelay = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EmergencyAlarm(_alarmDelay));
    }

    IEnumerator EmergencyAlarm(float delay)
    {
        yield return new WaitForSeconds(delay);
        
        foreach (GameObject lightGroup in lightGroups)
        {
            lightGroup.SetActive(true);
        }
    }

    IEnumerator EmergencyCall(float delay)
    {
        yield return new WaitForSeconds(delay);

        //Call on wrist pad...
    }
}
