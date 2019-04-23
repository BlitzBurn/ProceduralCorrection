using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject DudeGuyRef;

    private static float cameraMovementSpeed;

    void Start()
    {
        GameObject aiCharacter = GameObject.Find("DudeGuy");
        MoveCharacter moveCharacter = aiCharacter.GetComponent<MoveCharacter>();

        cameraMovementSpeed = moveCharacter.movementSpeed;
    }

   
    void Update()
    {
        Debug.Log(cameraMovementSpeed);
        transform.position = DudeGuyRef.transform.position + new Vector3(cameraMovementSpeed, transform.position.y, transform.position.z);
    }
}
