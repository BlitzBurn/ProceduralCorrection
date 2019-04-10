using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    public Transform ThisBlock;
    private Transform AIcharacter;

    private float distanceFromCharacter;

    [Range(10f, 90f)]
    public float maxDistance;

    [Range(5, 100)]
    public int numberOfBlocks;

    private float posX;

    private float newY;


    private void Awake()
    {
        ThisBlock = this.transform;
        AIcharacter = GameObject.FindGameObjectWithTag("AI").transform;

        for(float i=0; i<numberOfBlocks; i++)
        {
            Instantiate(ThisBlock, new Vector3(i,newY, 0), Quaternion.identity);
        }

    }



    void Update()
    {
        posX = transform.position.x;

        distanceFromCharacter = Vector3.Distance(ThisBlock.transform.position, AIcharacter.transform.position);

        newY = Random.Range(0, 6);

        if (distanceFromCharacter >= maxDistance)
        {
            ThisBlock.transform.position = new Vector3(posX + 50, newY, 0);
                
               
        }


    }
}
