using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//Script courtesy of Fist Full of Shrimp

[RequireComponent(typeof(Animator))]
public class AnimateHand_Controller : MonoBehaviour
{
    public InputActionReference gripInputActionReference;
    public InputActionReference triggerInputActionReference;

    private Animator _handAnimator;
    private float _gripValue;
    private float _triggerValue;
    // Start is called before the first frame update
    void Start()
    {
        _handAnimator = GetComponent<Animator>(); ;
    }

    // Update is called once per frame
    void Update()
    {
        AnimateGrip();
        AnimateTrigger();
    }

    private void AnimateGrip()
    {
        _gripValue = gripInputActionReference.action.ReadValue <float>();
        _handAnimator.SetFloat("Grip", _gripValue);
    }

    private void AnimateTrigger()
    {
        _triggerValue = triggerInputActionReference.action.ReadValue <float>();
        _handAnimator.SetFloat("Trigger", _triggerValue);
    }
}
