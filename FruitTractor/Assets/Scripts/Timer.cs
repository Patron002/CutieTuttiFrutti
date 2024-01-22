using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] GameSystem gameSystem;
    [SerializeField] private float timeStart = 60f;
    private int minutes;
    private int seconds;

    private void Update()
    {
        MoveTime();
        ShowTime();
    }

    private void MoveTime() 
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
        }
        else if (timeStart < 0) 
        {
            timeStart = 0;
            gameSystem.GameOver();
        }

        minutes = Mathf.FloorToInt(timeStart / 60);
        seconds = Mathf.FloorToInt(timeStart % 60);
    }

    private void ShowTime() 
    {
        timerText.text = string.Format("{0:00}:{1:00}",minutes, seconds);
    }

    
    
}
