using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Computer_Terminal_Manager : MonoBehaviour
{
    [SerializeField] private GameObject _doorTrigger;
    [SerializeField] private TextMeshProUGUI _ControlPanelScreenText;

    public void DoorOverride()
    {
        _doorTrigger.SetActive(true);
        _ControlPanelScreenText.text = "Override Successful... \n\nCommand Suite Doors are now open...";
    }
}
