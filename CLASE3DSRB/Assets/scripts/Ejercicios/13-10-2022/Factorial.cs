using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factorial : MonoBehaviour
{
    // Start is called before the first frame update
    public int num;
    void Start()
    {
        int res = 1;
		for (int i = num; i > 0; i--)
		{
            res *= i;
		}
        Debug.Log(res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
