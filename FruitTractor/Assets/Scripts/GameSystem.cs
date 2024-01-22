using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private GameObject PanelWin;
    [SerializeField] private GameObject PanelLose;
    [SerializeField] private DataBase database;
    [SerializeField] private Text TextWinCoin;
    [SerializeField] private int WinCoinCount;

    private void Start()
    {
        TextWinCoin.text = "+" + WinCoinCount.ToString();
    }

    public void GameOver() 
    {
        Pause();
        PanelLose.SetActive(true);
    }

    public void GameWin()
    {
        Pause();
        database.SetCoin(WinCoinCount);
        PanelWin.SetActive(true);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }
}
