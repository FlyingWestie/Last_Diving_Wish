using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuggageMover : MonoBehaviour
{
    public float speed;
    public Rigidbody rB;

    private void Start()
    {
        rB = GetComponent<Rigidbody>();
        rB.velocity = transform.up * speed;
    }
}
