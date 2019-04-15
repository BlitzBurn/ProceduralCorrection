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
    }
    //SendMessegeRaycast : CursorSphere
    void BlockRaycastMoveUp()
    {
        blockPosition.x = transform.position.x + movementRate;

        transform.position = blockPosition;
    }

    void Update()
    {
        
    }
}
