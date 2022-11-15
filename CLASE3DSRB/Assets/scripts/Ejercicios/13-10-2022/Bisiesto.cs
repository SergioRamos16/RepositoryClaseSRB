using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bisiesto : MonoBehaviour
{
    public int year;


    // Start is called before the first frame update
    void Start()
    {
		if ((year % 4 == 0 && year % 100 != 0) || year %400 == 0 )
		{
            Debug.Log("bisiesto");
		}
        else
        {
            Debug.Log("no bisiesto");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
