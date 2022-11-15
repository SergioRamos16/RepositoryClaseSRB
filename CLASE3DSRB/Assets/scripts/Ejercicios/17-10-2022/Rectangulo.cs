using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo 
{
    public float lado1, lado2;

    public float Perimetro() 
    {
        return lado1 * 2 + lado2 * 2;
    }

    public float Area()
    {
        return lado1 * lado2;
    }
}
