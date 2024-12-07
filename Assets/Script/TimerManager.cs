using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public TextMeshProUGUI timerScoreText;

    void Update()
    {
        timerScoreText.text = timerText.text;
    }
}
