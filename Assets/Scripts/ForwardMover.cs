using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] public float Speed;

    private void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }
}
