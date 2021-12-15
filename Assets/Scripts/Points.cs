using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public float point;
    public Text scoreText;

    private Text timeFinishedText;

      private void Update()
    {
        scoreText.text = point.ToString();

        if (point >= 4)
        {
          SceneManager.LoadScene(2);
        }
    }

}
