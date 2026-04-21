using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMode : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject playModePanel;

    public void ShowPlayMode()
    {
        mainMenuPanel.SetActive(false);
        playModePanel.SetActive(true);
    }

    public void BackToMenu()
    {
        playModePanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    // Optional (if you want scene loading)
    public void Play()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void NewGame()
    {
        Debug.Log("New Game");
    }

    public void LoadGame()
    {
        Debug.Log("Load Game");
    }
}