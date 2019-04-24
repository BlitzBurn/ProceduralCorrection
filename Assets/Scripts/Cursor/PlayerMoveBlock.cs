using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBlock : MonoBehaviour
{
    public float movementRate;
    private Vector3 blockPosition;
    private Vector3 movmentDirection;
    RaycastHit blockDetected;
    private float raylenght = 0.4f;


    void Start()
    {
        blockPosition = transform.position;
    }


    //SendMessegeRaycast : CursorSphere
    public void BlockRaycastMoveUp()
    {
        movmentDirection = new Vector3(0, 1, 0);

        StartCoroutine("moveBlockAndCheckIfpossible", movmentDirection);
    }

    public void BlockRaycastMoveDown()
    {
        movmentDirection = new Vector3(0, -1, 0);

        StartCoroutine("moveBlockAndCheckIfpossible", movmentDirection);
    }

    public void BlockRaycastMoveRight()
    {
        movmentDirection = new Vector3(1, 0, 0);

        StartCoroutine("moveBlockAndCheckIfpossible", movmentDirection);
    }

    public void BlockRaycastMoveLeft()
    {     
        movmentDirection = new Vector3(-1, 0, 0);

        StartCoroutine("moveBlockAndCheckIfpossible", movmentDirection);
    }


    IEnumerator moveBlockAndCheckIfpossible(Vector3 movementDirection)
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(movementDirection), out blockDetected, raylenght) && blockDetected.transform.tag=="BlockTag")
        {
            Debug.Log("Nej");
            return null;
        }
        else
        {
            transform.position = transform.position + movementDirection;

            return null;
        }
       
    }



}
