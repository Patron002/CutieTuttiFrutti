using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit_Score : MonoBehaviour
{
    [SerializeField] private Text TextCountFruitScore;
    [SerializeField] private Text TextCountFruitScoreMax;
    [SerializeField] private GameSystem gamesystem;
    [SerializeField] private float maxScoreFruit;
    [SerializeField] private float scoreFruit;

    private void Start()
    {
        scoreFruit = 0;

        TextReadScoreMax();
        TextReadScore();
    }

    public void Collectfruit() 
    {
        scoreFruit += 1;
        TextReadScore();
        CheckScoreFruit();
    }

    private void CheckScoreFruit() 
    {
        if (scoreFruit == maxScoreFruit) 
        {
            gamesystem.GameWin();
        }
    }

    private void TextReadScore() 
    {
        TextCountFruitScore.text = scoreFruit.ToString();
    }

    private void TextReadScoreMax()
    {
        TextCountFruitScoreMax.text = maxScoreFruit.ToString();
    }

}
