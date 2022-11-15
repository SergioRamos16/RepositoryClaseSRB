using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyPairs : MonoBehaviour
{
    public int min, max;
    // Start is called before the first frame update
    void Start()
    {
		if (min < max)
		{
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
