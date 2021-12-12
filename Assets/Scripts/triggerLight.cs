using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerLight : MonoBehaviour
{
    public GameObject light;

    void Start()
    {
        light.SetActive(false);
    }

    void OnTriggerEnter (Collider hit)
    {
        if (hit.tag == "Player")
        {
            light.SetActive (true);
        }
    }

    void OnTriggerExit (Collider hit)
    {
        if (hit.tag == "Player")
        {
            light.SetActive (false);
        }
    }
}
