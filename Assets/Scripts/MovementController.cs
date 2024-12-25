using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] float Speed;

    void FixedUpdate()
    {
        transform.position += transform.forward * Speed;
    }
}
