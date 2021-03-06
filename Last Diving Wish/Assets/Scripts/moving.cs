﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moving : MonoBehaviour
{
    public float moveSpeed = 3f;
    float velX;
    float velY;
    Rigidbody rigBody;
    public AudioClip luggage_catch;
    public AudioSource soundSource;
    float width;

    


    void Start()
    {
        rigBody = GetComponent<Rigidbody>(); 
    }

    void Awake()
    {
        width = (float)Screen.width / 2.0f;

    }
    // Update is called once per frame


    void Update()
    {
        velX = 0;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 pos = touch.position;
            pos.x = (pos.x - width) / width;
            if (pos.x < 0)
            {
                velX = -1;
            }
            else if (pos.x > 0)
            {
                velX = 1;
            }
            else
                velX = 0;
        }

        else
        {
            velX = Input.GetAxisRaw("Horizontal");
        }
        velY = rigBody.velocity.y;
            rigBody.velocity = new Vector2(velX * moveSpeed, velY);
        }
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Luggege"))
        {
            soundSource.Play();
            scoring.score1 += 1;
            if (scoring.score1 >= 10)
            {
                SceneManager.LoadScene("Win");
            }
        }

    }
}
