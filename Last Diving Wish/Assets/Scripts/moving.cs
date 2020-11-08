using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moving : MonoBehaviour
{
    public float moveSpeed = 3f;
    float velX;
    float velY;
    Rigidbody rigBody;
   

    void Start()
    {
        rigBody = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        velX = Input.GetAxisRaw("Horizontal");
        velY = rigBody.velocity.y;
        rigBody.velocity = new Vector2(velX * moveSpeed, velY);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Luggege"))
        {
            scoring.score1 += 1;
        }
    }
}
