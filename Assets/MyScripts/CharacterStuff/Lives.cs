using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int numberOfLives;
    // public GameObject dedZone;
    public DeathScript deathScript;

    void Start()
    {/*
        GameObject dedZone = GameObject.Find("");
        DeathScript EndGame = (DeathScript) dedZone.GetComponent<DeathScript>();
        ^*/
    }

    public void EasyMode()
    {
        numberOfLives = 3;
        Debug.Log(numberOfLives);
    }

    public void NormalMode()
    {
        numberOfLives = 2;
        Debug.Log(numberOfLives);
    }

    public void HardMode()
    {
        numberOfLives = 1;
        Debug.Log(numberOfLives);
    }


    void Update()
    {
        

        if (numberOfLives == 0)
        {
            // EndGame.endGame();
            deathScript.endGame();
        }

    }
}
