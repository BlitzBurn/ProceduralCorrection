using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScript : MonoBehaviour
{
    private Text gameOver;
    public GameObject playerCharacter;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    IEnumerator PlayerDeath()
    {

        Destroy(playerCharacter);
        return null;
    }
}
