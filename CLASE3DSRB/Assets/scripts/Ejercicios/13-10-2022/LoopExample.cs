using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        for (i = 100; i > 0; i--)
        {

            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
