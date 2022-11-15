using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    public int num;
    
    void Start()
    {
 

        Divisores(num);


    }

    
    public float Media(float x, float y, float z)
    {
        return (x + y + z) / 3;
    }

    public float PrecioConIva(float precio) 
    {
        float iva = precio * 0.21f;
        return precio + iva;
    }

    public void TablaMultiplicar(int numero) 
    {
		for (int i = 0; i <= 10; i++)
		{
            Debug.Log(numero + " por " + i + " es " + (numero * i));
		}
    }

    public void Divisores(int num)
    {
		for (int i = num; i > 0 ; i--)
		{
			if (num % i == 0)
			{
                Debug.Log(num + " es divisible por " + i);
			}
		}
    }



}
