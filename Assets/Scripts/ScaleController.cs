using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    [SerializeField] float Speed;

    void FixedUpdate()
    {
        transform.localScale += Vector3.one * Speed;
    }
}
