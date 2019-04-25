using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScript : MonoBehaviour
{  
    public GameObject playerCharacter;
    public GameObject cursor;
    public GameObject DeathScreen;
    private MoveCharacter moveChar;

    void Start()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("AI");
        moveChar = playerCharacter.GetComponent<MoveCharacter>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "AI")
        {
            // Destroy(collision.gameObject);
            moveChar.canMove = false;

            Destroy(cursor);


            DeathScreen.transform.gameObject.SetActive(true);
        }
    }        
}
