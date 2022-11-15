using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExamples : MonoBehaviour
{
	private void Update()
	{
		//if (Input.GetKeyDown(KeyCode.Space))
		//{
		//	Debug.Log("El player ha pulsado espacio");
		//}

		if (Input.GetButtonDown("Jump"))
		{
			Debug.Log("el jugador ha saltado");
		}

		if (Input.GetButtonDown("Fire1"))
		{
			Debug.Log("el jugador ha disparado");
		}

		//if (Input.GetKey(KeyCode.Space))
		//{
		//	Debug.Log("el player esta pulsando la tecla espacio");
		//}
		//if (Input.GetKeyUp(KeyCode.Space))
		//{
		//	Debug.Log("El player ha soltado la tecla");
		//}

		//if (Input.GetMouseButtonDown(0))
		//{
		//	Debug.Log("he pulsado el mouse");
		//}
	}
}