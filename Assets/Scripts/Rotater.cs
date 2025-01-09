using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] public Vector3 Direction;

    private void Update()
    {
        transform.Rotate(Direction * Time.deltaTime);
    }
}
