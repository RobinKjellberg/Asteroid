using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text ScoreText;
    public int score = 0;
    public int maxScore;


    void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score " + score;
    }

    void Update()
    {
        UpdateScore();
    }
    
}
