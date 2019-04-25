using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{

    public Transform MovableBlock;
    public Transform UnMovableBlock;
    

    [Range(5, 100)]
    public int numberOfBlocks;

    [Range(0, 100)]
    public int unmovableBlockSpawnRate;

    void Start()
    {

    

        for (float i = 0; i < numberOfBlocks; i++)
        {
            float startY = Random.Range(0,3);

            int blockType = Random.Range(0, 100);

            if (blockType >= unmovableBlockSpawnRate)
            {
                Instantiate(MovableBlock, new Vector3(i, startY, 0), Quaternion.identity);
            }
            else if(blockType<=unmovableBlockSpawnRate){
                Instantiate(UnMovableBlock, new Vector3(i, startY, 0), Quaternion.identity);
            }


            
        }
    }


    void Update()
    {
        
    }
}
