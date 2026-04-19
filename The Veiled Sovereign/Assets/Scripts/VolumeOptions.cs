using UnityEngine;

public class VolumeOptions : MonoBehaviour
{
    public GameObject volumePanel;
    public GameObject optionsPanel;

    public void BackToOption()
    {
        optionsPanel.SetActive(true);
        volumePanel.SetActive(false);
    }
}