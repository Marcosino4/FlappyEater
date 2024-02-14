using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int movement;
    public AudioMixer audioMixer;
    public bool changeScene = false;

    private void Start()
    {
        Time.timeScale = 1f;
        changeScene = false;
    }
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }


    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;

    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;

    }
    public void BackToMenu() //Volver al menu principal
    {
        if (!changeScene)
        {
            Time.timeScale = 1f;
            changeScene = true;
            SceneManager.LoadScene(0);
        }
    }

    public void PlayGame()
    {
        if (!changeScene)
        {
            changeScene = true;
            SceneManager.LoadScene(1);
        }

    }

    public void Restart()   //Reiniciar partida
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
