using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public float point;

    public Text scoreText;

    private void Update()
    {
        scoreText.text = point.ToString();
    }

}
