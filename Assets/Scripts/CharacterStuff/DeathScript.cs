using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScript : MonoBehaviour
{
    private Text gameOver;
    public GameObject playerCharacter;
    public GameObject cursor;
    public GameObject DeathScreen;

    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "AI")
        {
            Destroy(collision.gameObject);
            Destroy(cursor);


            DeathScreen.transform.gameObject.SetActive(true);
        }
    }

    IEnumerator PlayerDeath()
    {

        Destroy(playerCharacter);
        return null;
    }
}
