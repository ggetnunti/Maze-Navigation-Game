using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HightScore : MonoBehaviour
{
    public static string lv2Time, lv2hTime, lv3Time, lv3hTime, lv4Time, lv4hTime, lv5Time, lv5hTime;
    public static int lv2Coin, lv2hCoin, lv3Coin, lv3hCoin, lv4Coin, lv4hCoin, lv5Coin, lv5hCoin;
    public Text lv2TimeText, lv2CoinText, lv2hTimeText, lv2hCoinText, lv3TimeText, lv3CoinText, lv3hTimeText, lv3hCoinText, lv4TimeText, lv4CoinText, lv4hTimeText, lv4hCoinText, lv5TimeText, lv5CoinText, lv5hTimeText, lv5hCoinText;

    void Start()
    {
        lv2Time = PlayerPrefs.GetString("lv2Time");
        lv2Coin = PlayerPrefs.GetInt("lv2Coin");
        lv2hTime = PlayerPrefs.GetString("lv2hTime");
        lv2hCoin = PlayerPrefs.GetInt("lv2hCoin");

        lv3Time = PlayerPrefs.GetString("lv3Time");
        lv3Coin = PlayerPrefs.GetInt("lv3Coin");
        lv3hTime = PlayerPrefs.GetString("lv3hTime");
        lv3hCoin = PlayerPrefs.GetInt("lv3hCoin");

        lv4Time = PlayerPrefs.GetString("lv4Time");
        lv4Coin = PlayerPrefs.GetInt("lv4Coin");
        lv4hTime = PlayerPrefs.GetString("lv4hTime");
        lv4hCoin = PlayerPrefs.GetInt("lv4hCoin");

        lv5Time = PlayerPrefs.GetString("lv5Time");
        lv5Coin = PlayerPrefs.GetInt("lv5Coin");
        lv5hTime = PlayerPrefs.GetString("lv5hTime");
        lv5hCoin = PlayerPrefs.GetInt("lv5hCoin");
    }

    void Update()
    {
        lv2TimeText.text = lv2Time.ToString();
        lv2CoinText.text = lv2Coin.ToString();
        lv2hTimeText.text = lv2hTime.ToString();
        lv2hCoinText.text = lv2hCoin.ToString();

        lv3TimeText.text = lv3Time.ToString();
        lv3CoinText.text = lv3Coin.ToString();
        lv3hTimeText.text = lv3hTime.ToString();
        lv3hCoinText.text = lv3hCoin.ToString();

        lv4TimeText.text = lv4Time.ToString();
        lv4CoinText.text = lv4Coin.ToString();
        lv4hTimeText.text = lv4hTime.ToString();
        lv4hCoinText.text = lv4hCoin.ToString();

        lv5TimeText.text = lv5Time.ToString();
        lv5CoinText.text = lv5Coin.ToString();
        lv5hTimeText.text = lv5hTime.ToString();
        lv5hCoinText.text = lv5hCoin.ToString();
    }
}
