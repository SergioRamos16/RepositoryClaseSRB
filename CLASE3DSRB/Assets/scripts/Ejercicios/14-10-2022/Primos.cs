using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primos : MonoBehaviour
{
    // Start is called before the first frame update
    public int num;
    void Start()
    {

		for (int i = num -1; i > 1; i--)
		{
			if (num % i == 0)
			{
                Debug.Log("el numero no es primo");
                return;
			}
		}
        Debug.Log("El numero es primo");
    }

}
