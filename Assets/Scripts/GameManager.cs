using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    // [SerializeField] private GameObject _gameObjectCanvas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Time.timeScale = 1f;
    }
    /*
    public void GameOver()
    {
        _gameObjectCanvas.SetActive(true);

        Time.timeScale = 0f;
    }


    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    */
}
