using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ballPrefab;

     // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject b = Instantiate(ballPrefab, transform.position, transform.parent.rotation);

            float force = b.GetComponent<Ball>().speed;

            b.GetComponent<Rigidbody>().AddForce(b.transform.forward * force);
        }
    }
}
