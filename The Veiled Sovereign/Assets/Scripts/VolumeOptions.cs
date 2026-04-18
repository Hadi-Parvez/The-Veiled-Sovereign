using UnityEngine;

public class VolumeOptions : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject volumePanel;

    public void BackToOption()
    {
        optionsPanel.SetActive(true);
        volumePanel.SetActive(false);
    }
}
