using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JostickShip : MonoBehaviour, IShipInput
{
    public FixedJoystick joystick;
    public float Horizontal { get; private set; }

    public float Vertical { get; private set; }

    private void Update()
    {
        Horizontal = joystick.Horizontal;
        Vertical = joystick.Vertical;
    }
}