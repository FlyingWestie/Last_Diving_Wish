using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Moving1 : MonoBehaviour
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
            Destroy(GameObject.FindWithTag("Luggege"));
            if (scoring.score1 >= 15)
            {
                SceneManager.LoadScene("Win1");
            }
        }

    }
}
