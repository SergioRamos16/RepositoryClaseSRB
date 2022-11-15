using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichDays : MonoBehaviour
{
	int day;
    // Start is called before the first frame update
    void Start()
    {
		switch (day)
		{

			case 1:
				Debug.Log("monday");
				break;
			case 2:
				Debug.Log("tuesday");
				break;
			case 3:
				Debug.Log("wednesday");
				break;
			case 4:
				Debug.Log("thursday");
				break;
			case 5:
				Debug.Log("friday");
				break;
			case 6:
				Debug.Log("saturday");
				break;
			case 7:
				Debug.Log("sunday");
				break;
			default:
				Debug.Log("no existe ese dia de la semana");
				break;
			
		}
	}

}
