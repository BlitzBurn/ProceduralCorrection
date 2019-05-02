using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{

    public SFXplayer sfxplayer;

    [Range(0.01f, 1f)]
    public float RaycastLengthDown;

    [Range(0.01f, 5f)]
    public float RaycastLengthForward;

    RaycastHit forwardHit;
    RaycastHit downwardHit;

    [Range (1f, 8f)]
    public float jumpForce;

    private Rigidbody rd;

    public Transform self;

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

        Vector3 right = transform.TransformDirection(Vector3.right) * RaycastLengthForward;
        Debug.DrawRay(transform.position, right, Color.red);

        Vector3 down = transform.InverseTransformDirection(Vector3.down) * RaycastLengthDown;
       Debug.DrawRay(transform.position, down, Color.red);

        JumpStandard();
        Landing();
    }

    private void Landing()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out downwardHit, RaycastLengthDown) && groundContact == false)
        {
            sfxplayer.PlayJumpSound();
        }
    }


    private void JumpStandard()
    {

        

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out forwardHit, RaycastLengthForward) && groundContact == true)
        {
            sfxplayer.PlayJumpSound();
            rd.velocity = new Vector3(rd.velocity.x, jumpForce, 0);

        }
    }
}
