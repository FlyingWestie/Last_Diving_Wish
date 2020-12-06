using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    int health;
    public bool H = true;
    public bool H2 = true;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public AudioClip lose_health;
    public AudioSource soundSource;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 2 && H == true)
              H = false;
            heart3.SetActive(false);
        if (health == 1 && H2 == true)
             H2 = false;
            heart2.SetActive(false);
        if (health == 2 && H == false)
              H = true;
            heart3.SetActive(true);
        if (health == 1 && H2 == false)
             H2 = true;
            heart2.SetActive(true);    
        if (health == 0)
        {
            heart1.SetActive(false);
            SceneManager.LoadScene("Lose");
        }
    }
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag.Equals("debris"))
        {

            AddScore();
            // Destroy(GameObject.FindWithTag("debris"));

        }

          if (collision.gameObject.tag.Equals("Health"))
        {

            AddHealth();
            // Destroy(GameObject.FindWithTag("debris"));

        }

    }

    public void AddScore()
    {
        soundSource.Play();
        health -= 1;
        Destroy(GameObject.FindWithTag("debris"));
    }
      public void AddHealth()
    {
        soundSource.Play();
        health += 1;
        Destroy(GameObject.FindWithTag("Health"));
    }
}