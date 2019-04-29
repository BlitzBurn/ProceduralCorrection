using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    [Range(0.01f, 1f)]
    public float RaycastLengthDown;

    [Range(0.01f, 5f)]
    public float RaycastLengthForward;

    RaycastHit forwardHit;
    RaycastHit downwardHit;

    public float jumpForce;

    private Rigidbody rd;

    public Transform self;

    public float landingSpot;
    public float jumpHeight;

    public bool TypeOfJump;

    private bool groundContact;
    public LayerMask groundLayer;
    private Collider charCollider;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        charCollider = GetComponent<BoxCollider>();
    } 

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out downwardHit, RaycastLengthDown))
        {
            groundContact = true;
        }
        else
        {
            groundContact = false;
        }

        if (TypeOfJump == true)
        {
            JumpStandard();
        }
        else if (TypeOfJump == false)
        {
            JumpControlled();
        }

        Vector3 right = transform.TransformDirection(Vector3.right) * RaycastLengthForward;
        Debug.DrawRay(transform.position, right, Color.red);

        Vector3 down = transform.InverseTransformDirection(Vector3.down) * RaycastLengthDown;
        Debug.DrawRay(transform.position, down, Color.red);
    }

    private void JumpControlled()
    {

    }


    private void JumpStandard()
    {  
     

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out forwardHit, RaycastLengthForward) && groundContact == true)
        {
            rd.velocity = new Vector3(rd.velocity.x, jumpForce, 0);

        }
    }
}
