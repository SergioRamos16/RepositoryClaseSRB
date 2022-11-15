using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileImpares : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 500;
		do
		{
			if (x % 2 != 0)
			{
                Debug.Log(x);
			}
            x--;
		} while (x > 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
