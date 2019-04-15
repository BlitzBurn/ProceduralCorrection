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
        Debug.DrawRay(transform.position, inward, Color.red);

        if (Input.GetKey(KeyCode.UpArrow))            
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out blockHit, 100))
            {                
                blockHit.transform.SendMessage("BlockRaycastMoveUp", SendMessageOptions.DontRequireReceiver);                
            }            
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out blockHit, 100))
            {
                blockHit.transform.SendMessage("BlockRaycastMoveDown", SendMessageOptions.DontRequireReceiver);
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out blockHit, 100))
            {
                blockHit.transform.SendMessage("BlockRaycastMoveRight", SendMessageOptions.DontRequireReceiver);
            }
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out blockHit, 100))
            {
                blockHit.transform.SendMessage("BlockRaycastMoveLeft", SendMessageOptions.DontRequireReceiver);
            }
        }

    }
}
