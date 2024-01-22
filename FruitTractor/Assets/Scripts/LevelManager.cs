using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void Level1() 
    {
        SceneManager.LoadScene("TestLevel 1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("TestLevel 2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("TestLevel 3");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void MiniGame()
    {
        SceneManager.LoadScene("MiniGame");
    }
}
