using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;

    public GameObject volumePanel;
    public GameObject graphicsPanel;
    public GameObject keyBindsPanel;

    void HideAllSubPanels()
    {
        volumePanel.SetActive(false);
        graphicsPanel.SetActive(false);
        keyBindsPanel.SetActive(false);
    }

    public void ShowOptions()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);

        HideAllSubPanels();
    }

    public void OpenVolume()
    {
        HideAllSubPanels();
        volumePanel.SetActive(true);
    }

    public void OpenGraphics()
    {
        HideAllSubPanels();
        graphicsPanel.SetActive(true);
    }

    public void OpenKeyBinds()
    {
        HideAllSubPanels();
        keyBindsPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    public void BackToOptions()
    {
        HideAllSubPanels();
    }
}