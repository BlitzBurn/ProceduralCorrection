using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    [Range(0.01f, 10f)]
    public float RaycastLengthDown;

    [Range(0.01f, 5f)]
    public float RaycastLengthForward;

    RaycastHit forwardHit;
    RaycastHit downwardHit;

    public float jumpForce;

    private Rigidbody rd;

    public Transform self;

    public float airTimer;
    private float time;
    private bool airControl;

    private bool groundContact = false;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        time = airTimer + 1;
    }

    void JumpyJump()
    {
      //  rd.AddForce(self.up * jumpForce);
    }

    void Update()
    {
        time += Time.deltaTime;


        Vector3 right = transform.TransformDirection(Vector3.right) * RaycastLengthForward;
        Debug.DrawRay(transform.position, right, Color.red);

        Vector3 down = transform.InverseTransformDirection(Vector3.down) * RaycastLengthDown;
        Debug.DrawRay(transform.position, down, Color.red);

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out forwardHit, RaycastLengthForward) )
        {
            rd.AddForce(self.up*jumpForce);
            Debug.Log("does it work");
        }

       if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out downwardHit, RaycastLengthDown) && (downwardHit.transform.tag == "BottomTag"))
       {
           rd.AddForce(self.up * jumpForce);
       }
       




        if(time>=airTimer)
        {
            groundContact = true;
        }
        


        if (airTimer<=time)
        {
            
            groundContact = true;

        }

    }
}
