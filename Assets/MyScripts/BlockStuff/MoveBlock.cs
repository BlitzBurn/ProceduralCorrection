using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{

    public Transform ThisBlock;
    public Transform AIcharacter;

    private float distanceFromCharacter;

    [Range(0f, 100f)]
    public float maxDistance;


    private float posX;
    private float newY;


     void Start()
     {
        ThisBlock = this.transform;
        AIcharacter = GameObject.FindGameObjectWithTag("AI").transform;
       
     }
       
    void Update()
    {
        posX = transform.position.x;      
        
        distanceFromCharacter = Vector3.Distance(AIcharacter.transform.position,ThisBlock.position);        
        
        if (distanceFromCharacter >= maxDistance && ThisBlock.transform.position.x <= AIcharacter.transform.position.x)
        {
            newY = Random.Range(0, 6);

            ThisBlock.transform.position = new Vector3(posX + 50, newY, 0);

        }
    }
}
