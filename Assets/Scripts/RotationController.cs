using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField] Vector3 Speed;

    void FixedUpdate()
    {
        transform.Rotate(Speed);
    }
}
