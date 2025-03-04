using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Expands the XRDirectInteractor to handle climbing
/// Courtesy of David Brown -Medium.Com
/// https://medium.com/@dnwesdman/climbing-in-vr-with-the-xr-interaction-toolkit-164f6b381ed9
/// </summary>
public class XRDirectClimbInteractor : XRDirectInteractor
{
    public static event Action<string> ClimbHandActivated;
    public static event Action<string> ClimbHandDeactivated;

    private string _controllerName;

    protected override void Start()
    {
        base.Start();
        _controllerName = gameObject.name;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        if (args.interactableObject.transform.gameObject.tag == "Climb")
        {
            ClimbHandActivated?.Invoke(_controllerName);
        }
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        ClimbHandDeactivated?.Invoke(_controllerName);
    }
}
