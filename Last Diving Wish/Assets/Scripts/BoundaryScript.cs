using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Luggege"))
        {
            Destroy(GameObject.FindWithTag("Luggege"));
        }
        if (other.gameObject.tag.Equals("debris"))
        {
            Destroy(GameObject.FindWithTag("debris"));
        }
        if (other.gameObject.tag.Equals("powerup"))
        {
            Destroy(GameObject.FindWithTag("powerup"));
        }
    }
}
