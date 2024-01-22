using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitZoneTriger : MonoBehaviour
{
    [SerializeField] private Fruit_Score fruitscore;
    [SerializeField] private ButtonFruitControll buttonfruitcontroll;
    [SerializeField] private GameSystem gamesystem;
    [SerializeField] private int FruitTipId;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (buttonfruitcontroll.getFrut(FruitTipId))
        {
            fruitscore.Collectfruit();
            Destroy(this.gameObject);
        }
        else 
        {
            gamesystem.GameOver();
        }
        
    }
}
