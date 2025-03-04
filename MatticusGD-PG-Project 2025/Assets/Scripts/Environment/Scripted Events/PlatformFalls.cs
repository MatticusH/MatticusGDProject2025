using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformFalls : MonoBehaviour
{
    [SerializeField]
    private GameObject platform;
    [SerializeField]
    private Collider coll;

    // Start is called before the first frame update
    void Start()
    {
        coll = this.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Trigger Detects Collision");
        if (other.CompareTag("Player"))
        {
            print("Player has entered a trigger");
            platform.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
