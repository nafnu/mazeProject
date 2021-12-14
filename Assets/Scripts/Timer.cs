using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
   public float timeValue = 90;
   public Text timerText;

 // Update is called once per frame
 void Update()
 {
     if (timeValue > 0)
     {
         timeValue -= Time.deltaTime;
     }
     else
     {
         timeValue = 0;
         timerText.text = timeValue.ToString();
         SceneManager.LoadScene(3);
        }
     DisplayTime(timeValue);


 }

 void DisplayTime(float timeToDisplay)
 {
     if (timeToDisplay < 0)
     { 
         timeToDisplay = 0;
     }
     else if(timeToDisplay > 0)
     {
         timeToDisplay += 1;
     }

     float minutes = Mathf.FloorToInt(timeToDisplay / 60);
     float seconds = Mathf.FloorToInt(timeToDisplay % 60);

     timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);


 }
 }
    /*
    public int minutes;

    public int seconds;

    private int m, s;

    public Text TimerText;

    void Start()
    {

    }

    public void startTimer()
    {
        m = minutes;
        s = seconds;
        writeTimer(m, s);
        Invoke("updateTimer", 1f);
    }

    public void stopTimer()
    {

    }

    private void updateTimer()
    {
        s--;
        if (s < 0)
        {
            if (m == 0)
            {

            }
            else
            {
                m--;
                s = 59;
            }
        }

        writeTimer(m, s);
        Invoke("updateTimer", 1f);
    }

    private void writeTimer(int m, int s)
    {
        if (s < 10)
        {
            TimerText.text = m.ToString() + ":0" + s.ToString();
        }
        else
        {
            TimerText.text = m.ToString() + ":" + s.ToString();
        }
    }
    */


