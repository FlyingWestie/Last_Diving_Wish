using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public int speed;
 
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
   float v = Input.GetAxisRaw("Vertical");

   
   gameObject.transform.position = new Vector3 (transform.position.x + (h * speed), 
      transform.position.y + (v * speed));
    }
}
