
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
     public Text TextScore;
    public static int score1 = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = "Score: " + score1;
    }
}
