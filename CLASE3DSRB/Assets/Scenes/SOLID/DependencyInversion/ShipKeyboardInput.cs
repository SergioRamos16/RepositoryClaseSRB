using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipKeyboardInput : MonoBehaviour, IShipInput
{
    public float Horizontal { get; private set; }

    public float Vertical { get; private set; }

    private void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
    }
}