using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

//Courtesy of Fist Full Of Shrimp

public class SetPokeToFingerAttachPoint : MonoBehaviour
{
    public Transform PokeAttachPoint;

    private XRPokeInteractor _xrPokeInteractor;
    // Start is called before the first frame update
    void Start()
    {
        _xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
        SetPokeAttachPoint();
    }

    void SetPokeAttachPoint()
    {
        if (PokeAttachPoint == null) { Debug.Log("PokeAttach Point is Null"); return; }
        if(_xrPokeInteractor == null) { Debug.Log("XR Poke Interactor is Null"); return; }

        _xrPokeInteractor.attachTransform = PokeAttachPoint;
    }
}
