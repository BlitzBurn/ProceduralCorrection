using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{

    public Transform ThisBlock;


    [Range(5, 100)]
    public int numberOfBlocks;

    void Start()
    {

    

        for (float i = 0; i < numberOfBlocks; i++)
        {
            float startY = Random.Range(0,3);

            Instantiate(ThisBlock, new Vector3(i, startY, 0), Quaternion.identity);
        }
    }


    void Update()
    {
        
    }
}
