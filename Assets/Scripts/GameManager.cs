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

    // [SerializeField] private GameObject _gameObjectCanvas;
    private void Start()
    {
        Time.timeScale = 1f;
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
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
