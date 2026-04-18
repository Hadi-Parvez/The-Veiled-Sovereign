using UnityEngine;

public class DisplayOption : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject displayPanel;

    public void BackToOption()
    {
        optionsPanel.SetActive(true);
        displayPanel.SetActive(false);
    }
}
