using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject loadingScreen;
    public Button PauseButton;
    public Button ResumeButton;
    public Button BackToMenuButton;
    private bool changeScene = false;

    private void Start()
    {
        changeScene = false;
        Time.timeScale = 1f;
    }

    private void FixedUpdate()
    {
        PauseButton.onClick.AddListener(GameManager.instance.PauseGame);
        ResumeButton.onClick.AddListener(GameManager.instance.ResumeGame);
        BackToMenuButton.onClick.AddListener(BackToMenu);
   
    }

    public void BackToMenu()
    {
        if (!changeScene)
        {
            Time.timeScale = 1f;
            changeScene = true;
            SceneManager.LoadScene(0);
        }
    }
}
