using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    int health;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public AudioClip lose_health;
    public AudioSource soundSource;
    public AudioSource goodSource;
    public AudioClip gain_health;

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
        {
            heart1.SetActive(false);
            SceneManager.LoadScene("Lose");
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag.Equals("debris"))
        {
            AddScore();
        }

        else if (other.gameObject.tag.Equals("powerup"))
        {
            PowerUp();
            if (health == 2)
                heart2.SetActive(true);
            if (health == 3)
                heart3.SetActive(true);
            if (health > 3)
            {
                health = 3;
            }
        }

    }

    public void AddScore()
    {
        soundSource.Play();
        health -= 1;
        Destroy(GameObject.FindWithTag("debris"));
    }

    public void PowerUp()
    {
        goodSource.Play();
        health += 1;
        Destroy(GameObject.FindWithTag("powerup"));
    }

}