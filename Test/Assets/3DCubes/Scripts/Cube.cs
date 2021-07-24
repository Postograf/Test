using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
    private float _traveledDistance;

    public Rigidbody Rigidbody { get; private set; }
    public float LifeDistance { get; set; }

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void LateUpdate()
    {
        _traveledDistance += Rigidbody.velocity.magnitude;

        if (_traveledDistance >= LifeDistance)
        {
            Destroy(gameObject);
        }
    }
}
