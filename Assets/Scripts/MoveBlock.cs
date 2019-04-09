using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    private Transform ThisBlock;
    private Transform AIcharacter;

    private float distanceFromCharacter;

    [Range(10f, 90f)]
    public float maxDistance;

    private float posX;


    private void Awake()
    {
        ThisBlock = this.transform;
        AIcharacter = GameObject.FindGameObjectWithTag("AI").transform;
    }

    void Update()
    {
        posX = transform.position.x;

        distanceFromCharacter = Vector3.Distance(ThisBlock.transform.position, AIcharacter.transform.position);

        if (distanceFromCharacter >= maxDistance)
        {
            transform.position.x = posX + 50;
        }


    }
}
