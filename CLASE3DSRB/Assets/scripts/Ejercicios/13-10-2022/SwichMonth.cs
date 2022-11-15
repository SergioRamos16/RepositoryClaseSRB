using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichMonth : MonoBehaviour
{

    int month;
    // Start is called before the first frame update
    void Start()
    {
		switch (month)
		{
            case 1:
                Debug.Log("Enero");
                break;
            case 2:
                Debug.Log("Febrero");
                break;
            case 3:
                Debug.Log("Marzo");
                break;
            case 4:
                Debug.Log("Abril");
                break;
            case 5:
                Debug.Log("Mayo");
                break;
            case 6:
                Debug.Log("Junio");
                break;
            case 7:
                Debug.Log("Julio");
                break;
            case 8:
                Debug.Log("Agosto");
                break;
            case 9:
                Debug.Log("septiembre");
                break;
            case 10:
                Debug.Log("Octubre");
                break;
            case 11:
                Debug.Log("Noviembre");
                break;
            case 12:
                Debug.Log("Diciembre");
                break;


            default:
                Debug.Log("el mes no existe");
                break;
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
