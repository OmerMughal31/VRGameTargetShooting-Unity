using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Study what is object pooling

    public float launchForce = 10.0f;
    private Rigidbody _rigidBody = null;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public void Launch()
    {
        _rigidBody.AddRelativeForce(Vector3.forward * launchForce, ForceMode.Impulse);
        Destroy(gameObject, 5.0f);
    }
}
