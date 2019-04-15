using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
   
    

    [Range(-15f, 10f)]   
    public float cursorLocationZ;

    Vector3 positionOfCursor;

    void Start()
    {
        positionOfCursor = Input.mousePosition;
        positionOfCursor.z = cursorLocationZ;

    }


    void Update()
    {
        positionOfCursor.x = Input.mousePosition.x;
        positionOfCursor.y = Input.mousePosition.y;

        Vector3 mouseLocation = Camera.main.ScreenToWorldPoint(positionOfCursor);

        transform.position = mouseLocation;
    }

    public Vector3 CursorLocation(float cursorLocationX, float cursorLocationY, float cursorLocationZ)
    {

        cursorLocationX = transform.position.x;
        cursorLocationY = transform.position.y;
        cursorLocationZ = transform.position.z;

        Vector3 mousePosition = new Vector3(cursorLocationX, cursorLocationY, cursorLocationZ);

        return mousePosition;
    }
}
