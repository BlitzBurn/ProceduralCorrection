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

    private Rigidbody rd;

    void Start()
    {

        rd = GetComponent<Rigidbody>();

        characterPosition = transform.position;

       // positionY=transform.position.y;
       // positionZ = transform.position.z;
    }

    void OncollisionEnter(Collision collision)
    {
        Debug.Log("BEEPA BEEP");
    }

    void Update()
    {
        //characterPosition.x =transform.position.x +movementSpeed;

        rd.AddForce(self.right* movementSpeed);

        //transform.position = characterPosition;
  
       
        


    }
}
