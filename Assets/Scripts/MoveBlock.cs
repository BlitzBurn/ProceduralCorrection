using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{

    public Transform ThisBlock;


    public Transform AIcharacter;

    private float distanceFromCharacter;

    [Range(10f, 90f)]
    public float maxDistance;


    private float posX;

    private float newY;


     void start()
    {

       
    }



    void Update()
    {
        posX = transform.position.x;

        ThisBlock = GameObject.FindGameObjectWithTag("BlockTag").transform;

        AIcharacter = GameObject.FindGameObjectWithTag("AI").transform;

        distanceFromCharacter = Vector3.Distance(AIcharacter.transform.position, ThisBlock.position);

        newY = Random.Range(0, 6);

        Debug.Log(distanceFromCharacter);

        if (distanceFromCharacter >= maxDistance)
        {
            ThisBlock.transform.position = new Vector3(posX + 50, newY, 0);
            Debug.Log(distanceFromCharacter);
               
        }


    }
}
