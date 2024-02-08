using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button PlayButton;
    private bool changeScene = false;
    public Button QuitButton;

    private void Start()
    {
        changeScene = false;
        Time.timeScale = 1f;
    }

    private void FixedUpdate()
    {
        PlayButton.onClick.AddListener(PlayGame);
        QuitButton.onClick.AddListener(PlayGame);
    }

    public void PlayGame()
    {
        if (!changeScene)
        {
            changeScene = true;
            SceneManager.LoadScene(1);
        }

    }
    public void QuitGame()
    {
        Debug.Log("Quitted");
        Application.Quit();
    }
}
