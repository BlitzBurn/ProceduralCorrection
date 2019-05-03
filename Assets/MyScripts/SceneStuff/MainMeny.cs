using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeny : MonoBehaviour
{
    public Lives lives;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        if (Lives.difficultySet==false)
        {
            Lives.numberOfLives = 2;
        }

    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
