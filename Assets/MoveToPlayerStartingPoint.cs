using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerStartingPoint : MonoBehaviour
{
    public GameObject DudeGuy;
    private Rigidbody PlayerRigidBody;

    void Start()
    {
        PlayerRigidBody = DudeGuy.GetComponent<Rigidbody>();

        transform.position = PlayerRigidBody.position;
    }

    
    void Update()
    {
        
    }
}
