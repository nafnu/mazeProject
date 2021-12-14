using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public GameObject ObjPoints;
    public int pointsOffer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Arrow")
        {
            ObjPoints.GetComponent<Points>().point += pointsOffer;
            Destroy(gameObject);
        }
    }
}
