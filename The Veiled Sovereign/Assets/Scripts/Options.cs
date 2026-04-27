using UnityEngine;

public class Options : MonoBehaviour
{
    [Header("Main Panels")]
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;

    [Header("All Sub Panels")]
    public GameObject[] subPanels;

    // ------------------ OPEN OPTIONS ------------------

    public void OpenOptions()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);

        ShowPanel(0); // default panel (Display)
    }

    // ------------------ CORE FUNCTION ------------------

    public void ShowPanel(int index)
    {
        // Disable all panels
        foreach (GameObject panel in subPanels)
        {
            panel.SetActive(false);
        }

        // Enable selected panel
        subPanels[index].SetActive(true);
    }

    // ------------------ BACK ------------------

    public void BackToMenu()
    {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}