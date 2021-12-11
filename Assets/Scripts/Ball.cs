using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1000f;

     private void Update()
    {
        if(transform.position.y <= 0)
        {
            Destroy(gameObject);
        }
    }
}
