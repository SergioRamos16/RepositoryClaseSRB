using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo 
{
	public float radio = 3;


	public float Area()
	{
		return Mathf.PI * radio * radio;
	}

	public float Perimetro()
	{
		return 2 * radio * Mathf.PI;
	}

	public float Volumen()
	{
		return 4 / 3 * radio * radio * radio * Mathf.PI;
	}

}
