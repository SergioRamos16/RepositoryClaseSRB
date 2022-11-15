using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperatura : MonoBehaviour
{

    //C x 9 / 5 + 32
    // Start is called before the first frame update
    public float gradosCelsius;
    public float far;
    void Start()
    {

        far = gradosCelsius * 9 / 5 + 32;
        Debug.Log("la temperatura en kelvin son: " + far);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
