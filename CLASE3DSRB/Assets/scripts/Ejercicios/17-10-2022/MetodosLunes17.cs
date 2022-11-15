using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodosLunes17 : MonoBehaviour
{
    public int[] array;

    

    void Start()
    {

        Rand();

    }

    public void ShowArray() 
    {
		for (int i = 0; i < array.Length; i++)
		{
            Debug.Log(array[i]);
		}
    }

    public void ShowArrayInv() 
    {
		for (int i = array.Length -1; i >=0 ; i--)
		{
            Debug.Log(array[i]);
        }
    }


    public float MediaArray() 
    {
        float suma = 0;
		for (int i = 0; i < array.Length; i++)
		{
            suma += array[i];
		}
        float media = suma / array.Length;
        return media;
    }

    public void Rand() 
    {
		for (int i = 0; i < array.Length; i++)
		{
            array[i] = Random.Range(10, 1000);
		}
        
    
    }

}
