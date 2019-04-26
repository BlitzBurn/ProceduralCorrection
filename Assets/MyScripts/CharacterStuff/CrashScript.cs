using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashScript : MonoBehaviour
{
    public GameObject playerCharacter;
    private MoveCharacter moveChar;
    private Lives charLives;
    private Rigidbody rb;
    public float knockback;

    void Start()
    {
        playerCharacter = GameObject.FindGameObjectWithTag("AI");
        moveChar = playerCharacter.GetComponent<MoveCharacter>();
        charLives = playerCharacter.GetComponent<Lives>();

        rb = playerCharacter.GetComponent<Rigidbody>();
    }
 
    

    void OnCollisionEnter(Collision crash)    
    {
        
        if (crash.gameObject.tag=="BlockTag") {
            
            StartCoroutine(OnCrash());
        }
    }

    IEnumerator OnCrash()
    {
        charLives.numberOfLives= charLives.numberOfLives - 1;
        moveChar.canMove = false;
        Debug.Log("knockback1");
        rb.AddForce(knockback, 0, 0, ForceMode.Impulse);        
        
        yield return new WaitForSeconds(1);

        moveChar.canMove = true;

        //return null;
    }
}
