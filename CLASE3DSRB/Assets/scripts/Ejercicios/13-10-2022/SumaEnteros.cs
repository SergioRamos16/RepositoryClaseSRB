using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumaEnteros : MonoBehaviour
{
    public int min, max;
    void Start()
    {
        int res = 0;
		for (int i = min; i <= max; i++)
		{
            res = res +i;
		}
        Debug.Log(res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
