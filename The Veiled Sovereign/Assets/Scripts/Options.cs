using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;

    public GameObject volumePanel;
    public GameObject graphicsPanel;
    public GameObject keyBindsPanel;

    void Start()
    {
        ShowOptions(); // default view
    }

    // ---------------- PANEL CONTROL ----------------

    void HideAllSubPanels()
    {
        volumePanel.SetActive(false);
        graphicsPanel.SetActive(false);
        keyBindsPanel.SetActive(false);
    }

    public void ShowOptions()
    {
        HideAllSubPanels();
        optionsPanel.SetActive(true);
    }

    public void OpenVolume()
    {
        optionsPanel.SetActive(false);
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

    // ---------------- BACK ----------------

    public void BackToOptions()
    {
        ShowOptions();
    }

    public void BackToMenu()
    {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}