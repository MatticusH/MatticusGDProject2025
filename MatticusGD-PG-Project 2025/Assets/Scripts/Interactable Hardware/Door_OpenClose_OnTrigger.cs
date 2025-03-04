using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_OpenClose_OnTrigger : MonoBehaviour
{
    [SerializeField] Animator mAnimator;
    [SerializeField] bool mIsControlPanel;
    [SerializeField] GameObject mControlPanelScreen;
    private float mScreenDelay = 0.5f;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mAnimator.SetTrigger("TrOpen");
            if(mIsControlPanel)
            {
                bool onOff = true;
                StartCoroutine(ScreenOnOff(mScreenDelay, onOff));
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mAnimator.SetTrigger("TrClose");
            if(mIsControlPanel)
            {
                bool onOff = false;
                StartCoroutine(ScreenOnOff(mScreenDelay, onOff));                
            }
        }
    }

    IEnumerator ScreenOnOff(float delay, bool onOff)
    {
        yield return new WaitForSeconds(delay);

        if (onOff)
        {
            mControlPanelScreen.SetActive(true);
        }
        else
            mControlPanelScreen.SetActive(false);
    }
}
