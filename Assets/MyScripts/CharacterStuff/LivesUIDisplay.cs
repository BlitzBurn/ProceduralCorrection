using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesUIDisplay : MonoBehaviour
{
    public GameObject playerCharacter;  
    private Lives charLives;

    public Text Score;
    //public string newScore;
    private int count;

    void Start()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("AI");
        charLives = playerCharacter.GetComponent<Lives>();

        //count = charLives.numberOfLives; ;

        count = Lives.numberOfLives;

        Score.text = "Lives: " + count.ToString();
    }

    public void UpdateLives()
    {
        count = count - 1;

        Score.text = "Lives: " + count.ToString();
    }



}
