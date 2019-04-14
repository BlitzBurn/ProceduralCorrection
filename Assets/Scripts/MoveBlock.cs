using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{

    public GameObject DaBlock;
    public GameObject DudeGuy;

    public Transform ThisBlock;
    public Transform AIcharacter;

    private float distanceFromCharacter;

    [Range(-25f, 0f)]
    public float maxDistance;


    private float posX;

    private float newY;


     void Start()
    {

        ThisBlock = GameObject.FindGameObjectWithTag("BlockTag").transform;

        AIcharacter = GameObject.FindGameObjectWithTag("AI").transform;
        
       
    }



    void Update()
    {
        posX = transform.position.x;

      

        distanceFromCharacter =ThisBlock.position.x-AIcharacter.position.x;

        //distanceFromCharacter = Vector3.Distance(AIcharacter.transform.position,DaBlock.position);

        newY = Random.Range(0, 6);

        //Debug.Log(distanceFromCharacter);

        if (distanceFromCharacter <= maxDistance)
        {
            DaBlock.transform.position = new Vector3(posX + 50, newY, 0);
            //Debug.Log(distanceFromCharacter);

               
        }


    }
}
