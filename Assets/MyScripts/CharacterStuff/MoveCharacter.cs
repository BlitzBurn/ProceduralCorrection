using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    [Range (0.1f, 6f)]
    public float movementSpeed;   

    private Vector3 characterPosition;
    
    public Transform self;

    private Rigidbody characterRigidBody;

    public bool canMove;

    void Start()
    {
        characterRigidBody= GetComponent<Rigidbody>();

        characterPosition = transform.position;

        canMove = true;
    }

    

    void Update()
    {
        if (canMove == true) {
            characterRigidBody.velocity = new Vector3(movementSpeed, characterRigidBody.velocity.y, 0);
        }
        else if (canMove == false)
        {
            characterRigidBody.velocity = new Vector3(0, -1, 0);
        }
    }
}
