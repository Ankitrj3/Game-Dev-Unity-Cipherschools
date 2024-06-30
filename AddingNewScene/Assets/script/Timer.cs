

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Timer : MonoBehaviour
//{
//    public float timeValue = 180f;
//    private bool isTimerRunning = false;
//    private float currentTime;
//    public Text timeText;
//    public CollectablesManager collectablesManager;
//    private void Start()
//    {
//        StartTimer();
//    }

//    private void Update()
//    {
//        if (isTimerRunning)
//        {
//            currentTime -= Time.deltaTime;
//            if (currentTime <= 0.0f && !collectablesManager.allCoinsCollected)
//            {
//                currentTime = 0.0f;
//                isTimerRunning = false;

//                Debug.Log("Lost the Game");
//                GameManagerScript.instance.GameOverScreen(false);
//            }
//            if (collectablesManager.allCoinsCollected)
//            {
//                Debug.Log("Game Won");
//                GameManagerScript.instance.GameOverScreen(true);
//                isTimerRunning = false;
//            }

//            UpdateTimerText();
//        }
//    }

//    public void StartTimer()
//    {
//        isTimerRunning = true;
//        currentTime = timeValue;
//    }

//    void UpdateTimerText()
//    {
//        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
//        int seconds = Mathf.FloorToInt(currentTime % 60.0f);

//        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Initial time value in seconds
    public float timeValue = 180f;

    // Timer state
    private bool isTimerRunning = false;
    private float currentTime;

    // UI element to display time
    public Text timeText;

    // Reference to CollectablesManager to check coin collection status
    public CollectablesManager collectablesManager;

    // Start is called before the first frame update
    private void Start()
    {
        StartTimer();
    }

    // Update is called once per frame
    private void Update()
    {
        if (isTimerRunning)
        {
            // Update current time
            currentTime -= Time.deltaTime;

            // Check if time has run out and all coins are not collected
            if (currentTime <= 0.0f && !collectablesManager.allCoinsCollected)
            {
                currentTime = 0.0f;
                isTimerRunning = false;

                Debug.Log("Lost the Game");
                GameManagerScript.instance.GameOverScreen(false);
            }

            // Check if all coins have been collected
            if (collectablesManager.allCoinsCollected)
            {
                Debug.Log("Game Won");
                GameManagerScript.instance.GameOverScreen(true);
                isTimerRunning = false;
            }

            // Update the timer text
            UpdateTimerText();
        }
    }

    // Method to start the timer
    public void StartTimer()
    {
        isTimerRunning = true;
        currentTime = timeValue;
    }

    // Method to update the timer text
    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
        int seconds = Mathf.FloorToInt(currentTime % 60.0f);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
