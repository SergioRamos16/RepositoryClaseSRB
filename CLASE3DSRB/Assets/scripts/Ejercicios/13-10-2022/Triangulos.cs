using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulos : MonoBehaviour
{

    public float ladoA, ladoB, ladoC;

    // Start is called before the first frame update
    void Start()
    {
		if (ladoA == ladoB && ladoB == ladoC)
		{
			Debug.Log("equilatero");
		}
		else if (ladoA == ladoB || ladoB == ladoC  || ladoC == ladoA)
		{
			Debug.Log("isosceles");
		}
		else 
		{
			Debug.Log("escaleno");
		}
    }

    
}
