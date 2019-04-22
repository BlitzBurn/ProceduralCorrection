using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBlockColor : MonoBehaviour
{
    public Material[] blockMaterial;
    Renderer rend;

    public float colorResetTimer = 0.01f;
    private float time;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = blockMaterial[0];
    }

    void changeColorOfMarkedBlock()
    {
        Debug.Log("funkar skiten");
        rend.sharedMaterial = blockMaterial[1];
        time = 0f;
    }

    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= colorResetTimer)
        {
            rend.sharedMaterial = blockMaterial[0];
        }
    }
}
