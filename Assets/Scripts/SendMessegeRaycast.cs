using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessegeRaycast : MonoBehaviour
{

    RaycastHit blockHit;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        Vector3 inward = transform.TransformDirection(Vector3.forward) *100;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out blockHit, 100)) {
                blockHit.transform.SendMessage("BlockRaycastMoveUp", gameObject, SendMessageOptions.DontRequireReceiver);
            }
        }

    }
}
