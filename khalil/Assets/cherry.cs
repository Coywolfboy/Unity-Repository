using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cherry : MonoBehaviour
{
    public Text scoreText; 
    private int score = 0; 

    void Start()
    {

        score = 0;
        UpdateScoreText(); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cherry"))
        {
            score++;
            Destroy(other.gameObject);

            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
