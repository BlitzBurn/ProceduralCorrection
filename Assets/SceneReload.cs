using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneReload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        else if (Input.GetKeyDown("q"))
        {
            Application.Quit();
        }
    }
}
