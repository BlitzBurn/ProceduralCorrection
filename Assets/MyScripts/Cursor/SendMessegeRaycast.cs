using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessegeRaycast : MonoBehaviour
{
    RaycastHit blockHit;
    
    void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out blockHit, 100))
        {
            blockHit.transform.SendMessage("changeColorOfMarkedBlock", SendMessageOptions.DontRequireReceiver);          
        }

        
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out blockHit, 100))
        {

            Debug.DrawRay(transform.position, transform.forward, Color.blue);

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                blockHit.transform.SendMessage("BlockRaycastMoveUp", SendMessageOptions.DontRequireReceiver);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                blockHit.transform.SendMessage("BlockRaycastMoveDown", SendMessageOptions.DontRequireReceiver);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                blockHit.transform.SendMessage("BlockRaycastMoveRight", SendMessageOptions.DontRequireReceiver);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                blockHit.transform.SendMessage("BlockRaycastMoveLeft", SendMessageOptions.DontRequireReceiver);
            }

        }
    }


}
