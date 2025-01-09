using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] public float Speed;

    private void Update()
    {
        transform.localScale += Vector3.one * Speed * Time.deltaTime;
    }
}
