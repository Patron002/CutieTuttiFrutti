using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyLevel : MonoBehaviour
{
    [SerializeField] private DataBase database;
    [SerializeField] private LoadingTextCoin loadingtextcoin;
    [SerializeField] private int buycoinneed;
    [SerializeField] private Text textcoincountbuy;

    [SerializeField] private GameObject ButtonBuy;
    [SerializeField] private int levelbuy;
    [SerializeField] private Button ButtonActivate;

    private void Start()
    {
        textcoincountbuy.text = buycoinneed.ToString();
    }

    public void BuyLevelCheck() 
    {
        if (buycoinneed <= PlayerPrefs.GetInt("CoinCout"))
        {
            database.SetCoinBuy(buycoinneed, levelbuy);
            loadingtextcoin.LoadTextCoinCount();
            ButtonBuy.SetActive(false);
            ButtonActivate.interactable = true;
        }
        else 
        {

        }
    }
}
