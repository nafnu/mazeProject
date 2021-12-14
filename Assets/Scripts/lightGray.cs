using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightGray : MonoBehaviour
{
    public GameObject lightB;

    void Start()
    {
        lightB.SetActive(false);
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
            lightB.SetActive(true);
        }
    }

    void OnTriggerExit(Collider hit)
    {
        if (hit.tag == "Player")
        {
            lightB.SetActive(false);
        }
    }
}
