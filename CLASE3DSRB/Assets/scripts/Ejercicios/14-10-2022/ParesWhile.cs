using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParesWhile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
		while (i <100)
		{
			if (i % 2 == 0)
			{
             Debug.Log(i);
			}
            i++;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
