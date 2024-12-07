using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver, heart1, heart2, heart3, heart4, heart5, levelComplete;
    public static int health;
    public static bool isGameOver, isCompleteLevel;
    public string level;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Set 5 health when game start and hide game over and level complete UI
    void Start()
    {
        health = 5;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        heart5.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
        levelComplete.gameObject.SetActive(false);
    }

    // Check health is called once per frame, when zero health will show game over UI
    void Update()
    {
        if (health > 5)
        {
            health = 5;
        }
        switch(health)
        {
            case 5:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(true);
                break;
            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(false);
                break;
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            default:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                isGameOver = true;
                audioManager.PlaySFX(audioManager.gameover);
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
                break;
        }
    }

    // when complete the level will show level complete UI and calculate the hight score then record the result
    public void CompleteLevel()
    {
        TimerScript.activeTimer = false;
        levelComplete.gameObject.SetActive(true);
        isCompleteLevel = true;
        audioManager.PlaySFX(audioManager.levelcomplete);
        Cursor.lockState = CursorLockMode.None;
        switch (level)
        {
            case "lv2":
                HightScore("lv2Mins", "lv2Secs", "lv2Time", "lv2Coin");
                break;
            case "lv2h":
                HightScore("lv2hMins", "lv2hSecs", "lv2hTime", "lv2hCoin");
                break;
            case "lv3":
                HightScore("lv3Mins", "lv3Secs", "lv3Time", "lv3Coin");
                break;
            case "lv3h":
                HightScore("lv3hMins", "lv3hSecs", "lv3hTime", "lv3hCoin");
                break;
            case "lv4":
                HightScore("lv4Mins", "lv4Secs", "lv4Time", "lv4Coin");
                break;
            case "lv4h":
                HightScore("lv4hMins", "lv4hSecs", "lv4hTime", "lv4hCoin");
                break;
            case "lv5":
                HightScore("lv5Mins", "lv5Secs", "lv5Time", "lv5Coin");
                break;
            case "lv5h":
                HightScore("lv5hMins", "lv5hSecs", "lv5hTime", "lv5hCoin");
                break;
            default:
                break;
        }
        
    }

    // calculate the hight score
    void HightScore(string mins, string secs, string time, string coin)
    {
        if ((TimerScript.completeMins <= PlayerPrefs.GetInt(mins) && TimerScript.completeSecs <= PlayerPrefs.GetInt(secs)) || PlayerPrefs.GetString(time) == "")
        {
            PlayerPrefs.SetInt(mins, TimerScript.completeMins);
            PlayerPrefs.SetInt(secs, TimerScript.completeSecs);

            PlayerPrefs.SetString(time, TimerScript.completeTime);
        }
        if (CoinManager.coinCount >= PlayerPrefs.GetInt(coin))
        {
            PlayerPrefs.SetInt(coin, CoinManager.coinCount);
        }
    }
}
