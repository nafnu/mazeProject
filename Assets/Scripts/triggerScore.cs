using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScore : MonoBehaviour
{
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Arrow")
        {
            Debug.Log("point scored" +count);
            count++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
