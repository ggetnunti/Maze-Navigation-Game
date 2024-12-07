using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime;
    public static bool activeTimer = true;
    public static string completeTime;
    public static int completeMins, completeSecs;

    void Update()
    {
        if (activeTimer)
        {
            elapsedTime += Time.deltaTime;
        }
        int mins = Mathf.FloorToInt(elapsedTime / 60);
        int secs = Mathf.FloorToInt(elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", mins, secs);
        completeMins = mins;
        completeSecs = secs;
        completeTime = string.Format("{0:00}:{1:00}", mins, secs);
    }
}
