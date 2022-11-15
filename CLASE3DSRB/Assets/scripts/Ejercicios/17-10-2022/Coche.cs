using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche 
{
	public string Marca = "Audi";
	public float precio = 30000;

	public void Arrancar() 
	{
		Debug.Log("He arrancado el coche");
	}

	public void Frenar() 
	{
		Debug.Log("estoy frenando el coche");
	}
}
