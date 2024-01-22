using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameSystem : MonoBehaviour
{
    [SerializeField] DataBase database;
    [SerializeField] LevelManager levelmanager;
    [SerializeField] private int wincoin = 100;
    [SerializeField] private Text coinwintext;

    private int[] indexMassMiniGames = new int[9] { 0, 0, 0, 1, 1, 1, 2, 2, 2 };
    private int countTouch = 0;
    private int[] fruitCollect = new int[3];
    [SerializeField] private Sprite[] sprite;
    [SerializeField] private Image[] spriteImage;

    [SerializeField] private Button[] button;

    [SerializeField] private GameObject WinMiniGameButton;
    [SerializeField] private GameObject LoseMiniGameButton;

    private void Start()
    {
        textChangeCoinWin();
        RandomIndexMiniGame();
        RandomIndexImageSet();
    }

    private void RandomIndexMiniGame()
    {
        for (int i = indexMassMiniGames.Length - 1; i>= 1 ; i--)
        {
            int j = Random.Range(0, i + 1);

            int tmp = indexMassMiniGames[j];
            indexMassMiniGames[j] = indexMassMiniGames[i];
            indexMassMiniGames[i] = tmp;
        }

        for (int i = 0; i < indexMassMiniGames.Length; i++)
        {
            Debug.Log(indexMassMiniGames[i]);
        }
    }

    private void RandomIndexImageSet()
    {
        for (int i = 0; i < indexMassMiniGames.Length; i++)
        {
            switch (indexMassMiniGames[i])
            {
                case 0:
                    spriteImage[i].sprite = sprite[0];
                    break;
                case 1:
                    spriteImage[i].sprite = sprite[1];
                    break;
                case 2:
                    spriteImage[i].sprite = sprite[2];
                    break;
                default:
                    break;
            }
        }
    }

    private void WinMiniGameActivate() 
    {
        EndGameChangeButton();
        WinMiniGameButton.SetActive(true);
        Debug.Log("Yes");
    }

    private void LoseMiniGameActivate()
    {
        EndGameChangeButton();
        LoseMiniGameButton.SetActive(true);
        Debug.Log("No");
    }

    private void EndGameChangeButton() 
    {
        for (int i = 0; i < button.Length;i++) 
        {
            button[i].interactable = false;
        }
    }

    public void textChangeCoinWin() 
    {
        coinwintext.text = "+" + wincoin.ToString();
    }

    public void WinMiniGame() 
    {
        database.SetCoin(wincoin);
        levelmanager.MainMenu();
    }

    public void EndMinGame()
    {
        levelmanager.MainMenu();
    }

    public void CheckMiniGame(int ind)
    {
        fruitCollect[countTouch] = indexMassMiniGames[ind];
        countTouch++;
        if (countTouch == 3)
        {
            int maxEqual = 0;
            for (int i = 0; i < fruitCollect.Length; i++)
            {
                if (fruitCollect[0] == fruitCollect[i])
                {
                    maxEqual++;
                }
            }

            if (maxEqual == 3)
            {
                WinMiniGameActivate();
            }
            else
            {
                LoseMiniGameActivate();
            }
        }
    }

    public void Button1() 
    {
        int ind = 0;
        CheckMiniGame(ind);
    }
    public void Button2()
    {
        int ind = 1;
        CheckMiniGame(ind);
    }
    public void Button3()
    {
        int ind = 2;
        CheckMiniGame(ind);
    }
    public void Button4()
    {
        int ind = 3;
        CheckMiniGame(ind);
    }
    public void Button5()
    {
        int ind = 4;
        CheckMiniGame(ind);
    }
    public void Button6()
    {
        int ind = 5;
        CheckMiniGame(ind);
    }
    public void Button7()
    {
        int ind = 6;
        CheckMiniGame(ind);
    }
    public void Button8()
    {
        int ind = 7;
        CheckMiniGame(ind);
    }
    public void Button9()
    {
        int ind = 8;
        CheckMiniGame(ind);
    }

}
