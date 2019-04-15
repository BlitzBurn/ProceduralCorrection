using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBlock : MonoBehaviour
{
    public float movementRate;
    private Vector3 blockPosition;

    

    void Start()
    {
       blockPosition = transform.position;
       // spawnedBlock = Instantiate(PlayerMoveBlockSpawned) as GameObject;
    }


    //SendMessegeRaycast : CursorSphere
    public void BlockRaycastMoveUp()
    {
        blockPosition = transform.position;
        blockPosition.y = transform.position.y + movementRate;
        
        transform.position = blockPosition;
    }

    public void BlockRaycastMoveDown()
    {
        blockPosition = transform.position;
        blockPosition.y = transform.position.y - movementRate;

        transform.position = blockPosition;
    }

    public void BlockRaycastMoveRight()
    {
        blockPosition = transform.position;
        blockPosition.x = transform.position.x + movementRate;

        transform.position = blockPosition;
    }

    public void BlockRaycastMoveLeft()
    {
        blockPosition = transform.position;
        blockPosition.x = transform.position.x - movementRate;

        transform.position = blockPosition;
    }



    void Update()
    {
        
    }
}
