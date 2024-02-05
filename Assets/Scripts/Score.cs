using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance;
    public TextMeshProUGUI scoreText;
    private int _score = 0;
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    public void addPoints()
    {
        _score++;
        scoreText.SetText(_score.ToString());
    }
}
