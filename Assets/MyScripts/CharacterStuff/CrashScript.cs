using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashScript : MonoBehaviour
{
    public UIDisplay uiLives;

    public SFXplayer sfxplayer;

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
       Lives.numberOfLives = Lives.numberOfLives- 1;
        Debug.Log(Lives.numberOfLives);

        sfxplayer.PlayCrashSound();

        moveChar.canMove = false;        
        uiLives.UpdateLives();
       

        if (Lives.numberOfLives!=0) {
            rb.AddForce(knockback, 0, 0, ForceMode.Impulse);

            yield return new WaitForSeconds(1);
            moveChar.canMove = true;            
        }
        else if (Lives.numberOfLives == 0)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        //return null;
    }
}
