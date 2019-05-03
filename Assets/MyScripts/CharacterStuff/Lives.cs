using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public static int numberOfLives;
    private static int maxLives;
    public DeathScript deathScript;
    
    private bool testMode=false;
    public static bool difficultySet;

    private void Awake()
    {
        difficultySet = false;
        if (testMode == true)
        {
            numberOfLives = 3;
        }

        NormalMode();
    }

    public void EasyMode()
    {
        numberOfLives = 3;
        maxLives = 3;
        difficultySet = true;
      
    }

    public void NormalMode()
    {
        numberOfLives = 2;
        maxLives = 2;
        difficultySet = true;
    }

    public void HardMode()
    {
        numberOfLives = 1;
        maxLives = 1;
        difficultySet = true;
    }

    public void restart()
    {
        if (maxLives == 1)
        {
            EasyMode();
        }
        else if (maxLives == 2)
        {
            NormalMode();
        }
        else if (maxLives == 3)
        {
            HardMode();
        }
    }

    void Update()
    {/*
        if (difficultySet == false)
        {
            numberOfLives = 2;
        }
        */
        if (numberOfLives <= 0)
        {
            
            deathScript.endGame();
            
        }

    }
}
