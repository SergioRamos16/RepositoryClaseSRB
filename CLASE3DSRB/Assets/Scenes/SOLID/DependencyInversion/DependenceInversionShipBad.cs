using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DependenceInversionShipBad : MonoBehaviour
{
    public float movementSpeed = 10;
    public float rotationSpeed = 90;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += transform.forward * vertical * movementSpeed * Time.deltaTime;
        transform.Rotate(0, rotationSpeed * horizontal * Time.deltaTime, 0);
    }
}