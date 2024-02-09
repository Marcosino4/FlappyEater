using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public Button PauseButton;
    public Button ResumeButton;
    public Button BackToMenuButton;


    private void Start()
    {
        Time.timeScale = 1f;
        GameManager.instance.changeScene = false;
    }

    private void FixedUpdate()
    {
        PauseButton.onClick.AddListener(GameManager.instance.PauseGame);
        ResumeButton.onClick.AddListener(GameManager.instance.ResumeGame);
        BackToMenuButton.onClick.AddListener(GameManager.instance.BackToMenu);
   
    }


}
