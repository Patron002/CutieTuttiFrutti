using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DataBase : MonoBehaviour
{

    private void Start()
    {
        LoadCoin();
    }

    private void SaveCoinWin(int coinwincollect)
    {
        int totalCoin = PlayerPrefs.GetInt("CoinCout");
        PlayerPrefs.SetInt("CoinCout", totalCoin + coinwincollect);
        PlayerPrefs.Save();
    }

    private void SaveBuyCoin(int coinwincollect, int level)
    {
        int totalCoin = PlayerPrefs.GetInt("CoinCout");
        PlayerPrefs.SetInt("CoinCout", totalCoin - coinwincollect);
        switch (level) 
        {
            case 2:
                PlayerPrefs.SetInt("Level2", 1);
                break;
            case 3:
                PlayerPrefs.SetInt("Level3", 1);
                break;
            default:
                break;
        }

        PlayerPrefs.Save();
    }

    private void FirstOpenGameSaveBase() 
    {
        PlayerPrefs.SetInt("CoinCout", 0);
        PlayerPrefs.SetInt("Level2", 0);
        PlayerPrefs.SetInt("Level3", 0);
        PlayerPrefs.Save();
    }

    private void LoadCoin()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("SavedInteger", 1);
            FirstOpenGameSaveBase();
        }
    }

    public float GetCoin() 
    {
        return PlayerPrefs.GetInt("CoinCout");
    }

    public void SetCoin(int coin)
    {
        SaveCoinWin(coin);
    }

    public void SetCoinBuy(int coin, int level)
    {
        SaveBuyCoin(coin, level);
    }


}
