using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckBuyLevel : MonoBehaviour
{
    [SerializeField] private Button buttonlevel2;
    [SerializeField] private GameObject buttonlevel2buy;
    [SerializeField] private Button buttonlevel3;
    [SerializeField] private GameObject buttonlevel3buy;

    private void Start()
    {
        CheckLevelOpen();
    }

    private void CheckLevelOpen() 
    {
        if (PlayerPrefs.GetInt("Level2") == 1) 
        {
            buttonlevel2.interactable = true;
            buttonlevel2buy.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Level3") == 1)
        {
            buttonlevel3.interactable = true;
            buttonlevel3buy.SetActive(false);
        }
    }
}
