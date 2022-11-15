using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseProjectil : MonoBehaviour
{
    public Rigidbody rb;
    public float shootForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public virtual void ShootProjectile(Vector3 shootDirection)
    {
    }
}