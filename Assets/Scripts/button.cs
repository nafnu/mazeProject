using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
   public void OnButton()
    {
        Debug.Log("Button was pressed");
    }

    public void OnStartButton()
    {
        Debug.Log("Button PLAY was pressed");
    }

    public void OnEXITButton()
    {
        Debug.Log("Button EXIT was pressed");
    }
}
