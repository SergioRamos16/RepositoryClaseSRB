using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCirculo : MonoBehaviour
{
    public float radio;
    private const float miConstante = 3;
    // Start is called before the first frame update
    void Start()
    {
        float area = radio * radio * Mathf.PI;
        Debug.Log("el area del circulo: " +area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
