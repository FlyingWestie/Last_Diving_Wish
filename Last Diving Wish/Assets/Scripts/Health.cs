﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    int health;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 2)
            heart3.SetActive(false);
        if (health == 1)
            heart2.SetActive(false);
        if (health == 0)
            heart1.SetActive(false);
        //SceneManager.LoadScene("Lose");
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("debris"))
        {

            AddScore();


        }

    }

    public void AddScore()
    {
        health -= 1;
    }
}