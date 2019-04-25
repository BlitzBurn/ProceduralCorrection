using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int numberOfLives;
    public GameObject dedZone;
    

    void Start()
    {
        
        
    }

  
    void Update()
    {
        DeathScript EndGame = dedZone.GetComponent<DeathScript>();

        if (numberOfLives == 0)
        {
            EndGame.endGame();
        }

    }
}
