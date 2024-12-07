using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public Text coinText;
    public static int coinCount;

    void Update()
    {
        coinText.text = "" + Mathf.Round(coinCount);
    }
}
