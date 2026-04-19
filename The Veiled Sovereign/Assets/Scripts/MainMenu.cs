using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject playModePanel;

    void Start()
    {
        ShowMainMenu(); // default state
    }

    // ------------------ PANEL CONTROL ------------------

    void HideAllPanels()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        playModePanel.SetActive(false);
    }

    public void ShowMainMenu()
    {
        HideAllPanels();
        mainMenuPanel.SetActive(true);
    }

    public void ShowOptions()
    {
        HideAllPanels();
        optionsPanel.SetActive(true);
    }

    public void ShowPlayMode()
    {
        HideAllPanels();
        playModePanel.SetActive(true);
    }

    // ------------------ BUTTON ACTIONS ------------------

    public void PlayGame()
    {
        ShowPlayMode(); // instead of loading scene
    }

    public void OpenOptions()
    {
        ShowOptions();
    }

    public void BackToMainMenu()
    {
        ShowMainMenu();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}