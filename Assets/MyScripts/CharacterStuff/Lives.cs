using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public static int numberOfLives;
    private static int difficulty;
    public DeathScript deathScript;

   
    public void EasyMode()
    {
        numberOfLives = 3;
        difficulty = 1;
      
    }

    public void NormalMode()
    {
        numberOfLives = 2;
        difficulty = 2;
        
    }

    public void HardMode()
    {
        numberOfLives = 1;
        difficulty = 3;
        
    }


    void Update()
    {
      //  Debug.Log(numberOfLives);

        if (numberOfLives == 0)
        {           
            deathScript.endGame();
        }

    }
}
