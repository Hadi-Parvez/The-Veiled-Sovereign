using UnityEngine;
public class Options : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;

    public GameObject volumePanel;
    public GameObject displayPanel;
    public GameObject graphicsPanel;
    public GameObject keyBindsPanel;

    public void BackToMenu()
    {
        mainMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }
    public void BackToGame()
    {
        mainMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
    }
    public void OpenVolume()
    {
        optionsPanel.SetActive(false);
        volumePanel.SetActive(true);
    }
    public void OpenDisplay()
    {
        optionsPanel.SetActive(false);
        displayPanel.SetActive(true);
    }
    public void OpenGraphics()
    {
        optionsPanel.SetActive(false);
        graphicsPanel.SetActive(true);
    }
    public void OpenKeyBinds()
    {
        optionsPanel.SetActive(false);
        keyBindsPanel.SetActive(true);
    }
}
