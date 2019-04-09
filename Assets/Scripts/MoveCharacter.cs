using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [Range (0.01f, 3f)]
    public float movementSpeed;

    private Vector3 characterPosition;
    private float positionX, positionY, positionZ;


    void Start()
    {
        characterPosition = transform.position;

       // positionY=transform.position.y;
       // positionZ = transform.position.z;
    }
    //testar
    void Update()
    {
        characterPosition.x =transform.position.x +movementSpeed;
       transform.position = characterPosition;
       
    }
}
