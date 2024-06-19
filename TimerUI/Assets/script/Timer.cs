//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//public class Timer : MonoBehaviour
//{
//    public float timeValue = 60f;
//    private bool isTimerRunning = false;
//    private float currentTime;
//    public Text timeText;

//    private void Start()
//    {
//        isTimerRunning = true;
//        currentTime = timeValue;

//    }
//    private void Update()
//    {
//        if (isTimerRunning)
//        {
//        currentTime = currentTime - Time.deltaTime;
//            if (currentTime <= 0.0f)
//            {
//                currentTime = 0.0f;
//                isTimerRunning = false;
//            }

//                UpdateTimerText();
//        }
//    }
//   void UpdateTimerText()
//    {
//        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
//        int seconds = Mathf.FloorToInt(currentTime%60.0f);

//        timeText.text = string.Format("{0.00}:{1:00}",minutes,seconds);
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 60f;
    private bool isTimerRunning = false;
    private float currentTime;
    public Text timeText;

    private void Start()
    {
        StartTimer();
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0.0f)
            {
                currentTime = 0.0f;
                isTimerRunning = false;
            }

            UpdateTimerText();
        }
    }

    public void StartTimer()
    {
        isTimerRunning = true;
        currentTime = timeValue;
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
        int seconds = Mathf.FloorToInt(currentTime % 60.0f);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}