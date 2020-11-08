using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesScript : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (0, 0, speed * Time.deltaTime, 0);
    }
}
