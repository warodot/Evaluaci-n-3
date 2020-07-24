using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBehaviour : MonoBehaviour
{
    public TextMeshProUGUI hiScoreText;
    public TextMeshProUGUI scoreText;

    public int hiScore;
    public int score;


    public void AddScore(int amount)
    {
        score += amount;

        if (score > hiScore)
        {
            hiScore = score;
        }


        scoreText.SetText("SCORE: " + score.ToString("0000"));
        hiScoreText.SetText("HIGHSCORE: " + hiScore.ToString("0000"));
    }
}
