using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    Text CoinTexts;
    public static int Coin;
    void Start()
    {
        Coin += 1100;
        CoinTexts = GetComponent<Text>();
        Coin = PlayerPrefs.GetInt("Coins1", Coin);
    }

    // Update is called once per frame
    void Update()
    {
        CoinTexts.text = Coin.ToString();
    }
}
