using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaysInMonth : MonoBehaviour
{
    public int month;
    public string myString;
    string  fruta = "platano";
    // Start is called before the first frame update
    void Start()
    {

		switch (myString)
		{
            case "platano":
                break;
            case "manzana":
                break;
         
                


			default:
				break;
		}


		switch (month)
		{
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Debug.Log("El mes " + month + "tiene 31 dias");
                break;
            case 2:
                Debug.Log("El mes " + month + "tiene 28 dias");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Debug.Log("El mes " + month + "tiene 30 dias");
                break;
			default:
				break;
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
