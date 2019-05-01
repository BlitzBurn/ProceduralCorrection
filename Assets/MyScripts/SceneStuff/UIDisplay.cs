using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    public GameObject playerCharacter;
    public GameObject gameController;

    private Lives charLives;
    private ScoreScript charDistance;

    public Text LivesUItext;
    public Text ScoreUItext;
    
    private int livesCount;
    private float scoreCount;

    void Start()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("AI");
        charLives = playerCharacter.GetComponent<Lives>();

        gameController = GameObject.FindGameObjectWithTag("GameController");
        charDistance = gameController.GetComponent<ScoreScript>();

        scoreCount = 0;
        livesCount = Lives.numberOfLives;

        LivesUItext.text = "Lives: " + livesCount.ToString();
        ScoreUItext.text = "Score: " + scoreCount.ToString();
    }

    private void Update()
    {
        scoreCount = ScoreScript.Distance;
        UpdateScore();
    }

    public void UpdateLives()
    {
        livesCount = livesCount - 1;

        LivesUItext.text = "Lives: " + livesCount.ToString();
    }

    public void UpdateScore()
    {
        scoreCount = ScoreScript.Distance;
        ScoreUItext.text = "Distance: "+scoreCount.ToString("F0");
    }


}
