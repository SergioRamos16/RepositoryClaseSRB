using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaRectangulo : MonoBehaviour
{
    // Start is called before the first frame update
    public float ancho;
    public float largo;
    public float res;
    void Start()
    {
        res = ancho * largo;
        Debug.Log("el area del rectangulo es " + res + " metros"  );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
