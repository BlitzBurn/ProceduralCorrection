using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject DudeGuyRef;
    private float cameraPosX;
    private Vector3 DudeGuyPosition;

    void Update()
    {
        DudeGuyPosition = GameObject.Find("DudeGuy").transform.position;
        cameraPosX = DudeGuyPosition.x;
        transform.position = new Vector3(cameraPosX, 5, 0);
    }
}
