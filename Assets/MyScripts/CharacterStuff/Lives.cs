using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public static int numberOfLives;
    private static int maxLives;
    public DeathScript deathScript;
    
    public bool testMode;

    private void Awake()
    {
        if (testMode == true)
        {
            numberOfLives = 3;
        }
    }

    public void EasyMode()
    {
        numberOfLives = 3;
        maxLives = 1;
      
    }

    public void NormalMode()
    {
        numberOfLives = 2;
        maxLives = 2;
        
    }

    public void HardMode()
    {
        numberOfLives = 1;
        maxLives = 3;
        
    }


    void Update()
    {
      //  Debug.Log(numberOfLives);

        if (numberOfLives == 0)
        {           
            deathScript.endGame();
            numberOfLives = maxLives;
        }

    }
}
