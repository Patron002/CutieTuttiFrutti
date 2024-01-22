using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingTextCoin : MonoBehaviour
{
    [SerializeField] Text countCoin;
    [SerializeField] DataBase dataBase;

    private void Start()
    {
        LoadTextCoinCount();
    }

    public void LoadTextCoinCount() 
    {
        countCoin.text = dataBase.GetCoin().ToString();
    }
}
