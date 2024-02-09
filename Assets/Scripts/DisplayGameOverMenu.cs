using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    private void OnEnable()
    {
        EyeBehaviour.onPlayerDeath += DisplayGameOverMenu;
    }
    private void OnDisable()
    {
        EyeBehaviour.onPlayerDeath -= DisplayGameOverMenu;
    }
    public void DisplayGameOverMenu()
    {
        gameOver.gameObject.SetActive(true);
    }
}
