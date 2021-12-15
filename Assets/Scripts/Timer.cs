using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
   bool timerActive = false;

   public float timeValue = 90;
   public Text timerText;

 // Update is called once per frame
 void Update()
 {
     if (timeValue > 0)
     {
         timerActive = true;
         timeValue -= Time.deltaTime;
         
     }
     else
     {
         timeValue = 0;
         timerText.text = timeValue.ToString();
         timerActive = false;
         SceneManager.LoadScene(3);
        }
     DisplayTime(timeValue);

     if(timerActive == true)
       {
            timeValue = timeValue - Time.deltaTime;
        }


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
   
