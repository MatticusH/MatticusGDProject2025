using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InHMDStats : MonoBehaviour
{
    //fps stuff
    [Tooltip("FPS Rate Refresh Frequency")]
    public float updateDelay = 0f;

    //[Tooltip("FPS Target Color Changer")]
    [SerializeField, Tooltip("FPS Target Color Changer")]
    private TargetFPS _targetFPS = TargetFPS.FPS_72;
    private float _currentFPS = 0f;
    private float _deltaTime = 0f;

    [SerializeField]
    private TextMeshProUGUI _textFPS;

    void Start()
    {
        StartCoroutine(DisplayFramesPerSecond());
    }

    //FPS Display Methods
    private IEnumerator DisplayFramesPerSecond()
    {
        while (true)
        {
            if (_currentFPS > -(int)_targetFPS)
            {
                _textFPS.color = new Color32(0, 177, 215, 255);
            }
            else
            {
                _textFPS.color = new Color32(200, 68, 124, 255);
            }
            _textFPS.text = "(Vulkan) FPS: " + _currentFPS.ToString(".0");
            yield return new WaitForSeconds(updateDelay);
        }
    }

    public enum TargetFPS
    {
        FPS_60 = 60,
        FPS_72 = 72,
        FPS_90 = 90,
        FPS_120 = 120
    }

    private void Update()
    {
        _deltaTime += (Time.deltaTime - _deltaTime) * 0.1f;
        _currentFPS = 1.0f / _deltaTime;
    }
}
