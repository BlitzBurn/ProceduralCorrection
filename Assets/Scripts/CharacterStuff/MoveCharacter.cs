using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [Range (0.01f, 90f)]
    public float movementSpeed;   

    private Vector3 characterPosition;
    private float positionX, positionY, positionZ;

    public Transform self;

    private Rigidbody characterRigidBody;

    void Start()
    {
        characterRigidBody= GetComponent<Rigidbody>();

        characterPosition = transform.position;
    }

    

    void Update()
    {
        characterRigidBody.velocity = new Vector3(movementSpeed, characterRigidBody.velocity.y, 0);
    }
}
