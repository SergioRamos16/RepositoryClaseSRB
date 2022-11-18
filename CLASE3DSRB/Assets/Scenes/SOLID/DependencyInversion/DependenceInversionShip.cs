using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DependenceInversionShip : MonoBehaviour
{
    public float movementSpeed = 10;
    public float rotationSpeed = 90;

    private IShipInput shipInput;

    private void Awake()
    {
        shipInput = GetComponent<IShipInput>();
    }

    private void Update()
    {
        float horizontal = shipInput.Horizontal;
        float vertical = shipInput.Vertical;
        transform.position += transform.forward * vertical * movementSpeed * Time.deltaTime;
        transform.Rotate(0, rotationSpeed * horizontal * Time.deltaTime, 0);
    }
}