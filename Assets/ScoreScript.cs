using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public GameObject DudeGuy;

    private Vector3 StartingPoint;

    public static float Distance;

    void Start()
    {
        StartingPoint = DudeGuy.transform.position;
    }

   
    void Update()
    {       
        Distance = DudeGuy.transform.position.x - StartingPoint.x;
    }
}
