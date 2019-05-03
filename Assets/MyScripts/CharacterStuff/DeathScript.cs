using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScript : MonoBehaviour
{  
    public GameObject playerCharacter;
    public GameObject cursor;
    public GameObject DeathScreen;

    public GameObject hat;
    public GameObject brokenHat;

    private MoveCharacter moveChar;

    public SFXplayer sfxplayer;

    void Start()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("AI");
        moveChar = playerCharacter.GetComponent<MoveCharacter>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "AI")
        {
            endGame();
        }

        
    }

    public void endGame()
    {
        // Destroy(collision.gameObject);
        sfxplayer.PlayGameOverSound();

        moveChar.canMove = false;
        Debug.Log("Deathscript");
        Destroy(cursor);

        hat.transform.gameObject.SetActive(false);
        brokenHat.transform.gameObject.SetActive(true);

        DeathScreen.transform.gameObject.SetActive(true);
    }
}
