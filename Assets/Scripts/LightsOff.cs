using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOff : MonoBehaviour
{
    public Light myLight;

    void LightSwitch()
    {
        myLight.enabled = !myLight.enabled;
    }
  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            LightSwitch();
        }
    }
}
