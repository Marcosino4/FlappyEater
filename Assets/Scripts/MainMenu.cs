using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button PlayButton;
    public Button QuitButton;

    private void Start()
    {
        Time.timeScale = 1f;
        GameManager.instance.changeScene = false;
    }

    private void FixedUpdate()
    {
        PlayButton.onClick.AddListener(GameManager.instance.PlayGame);
        QuitButton.onClick.AddListener(QuitGame);
    }

    public void QuitGame()
    {
        Debug.Log("Quitted");
        Application.Quit();
    }
}
