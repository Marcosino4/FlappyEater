using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI scoreText;
    public int score = 0;
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    public void addPoints()
    {
        score++;
        scoreText.SetText(score.ToString());
    }

    public int GetScore()
    {
        return score;
    }
}
