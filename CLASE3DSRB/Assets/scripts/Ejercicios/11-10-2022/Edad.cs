using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edad : MonoBehaviour
{
    public int edad = 18;
    void Start()
    {
        if (edad < 18)
        {
            Debug.Log("esta persona es mayor de edad");
        }
        else {
            Debug.Log("esta persona es menor de edad");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
