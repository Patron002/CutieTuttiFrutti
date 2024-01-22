using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFruitControll : MonoBehaviour
{
    [SerializeField] private bool[] fruitTip = new bool[2];

    private void Start()
    {
        fruitTip[0] = true;
        fruitTip[1] = false;
    }

    public void OneButtonFrut() 
    {
        fruitTip[0] = true;
        fruitTip[1] = false;
    }

    public void TwoButtonFrut()
    {
        fruitTip[0] = false;
        fruitTip[1] = true;
    }

    public bool getFrut(int indexFruit) 
    {
        return fruitTip[indexFruit];
    }
}
