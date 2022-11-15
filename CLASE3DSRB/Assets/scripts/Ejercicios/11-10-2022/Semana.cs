using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semana : MonoBehaviour
{
    public int diaDeLaSemana;

    // Start is called before the first frame update
    void Start()
    {
		if (diaDeLaSemana == 1)
		{
            Debug.Log("Lunes");
		}
        if (diaDeLaSemana == 2)
        {
            Debug.Log("Martes");
        }
        if (diaDeLaSemana == 3)
        {
            Debug.Log("Miercoles");
        }
        if (diaDeLaSemana == 4)
        {
            Debug.Log("Jueves");

        }
        if (diaDeLaSemana == 5)
        {
            Debug.Log("Viernes");
        }
        if (diaDeLaSemana == 6)
        {
            Debug.Log("Sabado");

        }
        if (diaDeLaSemana == 7)
        {
            Debug.Log("Domingo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
