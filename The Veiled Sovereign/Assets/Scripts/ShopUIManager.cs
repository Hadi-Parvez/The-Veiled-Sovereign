using UnityEngine;

public class ShopUIManager : MonoBehaviour
{
    public GameObject shopPanel;

    public GameObject skillsPanel;
    public GameObject storePanel;
    public GameObject equipmentPanel;

    void Start()
    {
        shopPanel.SetActive(false);
    }

    void HideAll()
    {
        skillsPanel.SetActive(false);
        storePanel.SetActive(false);
        equipmentPanel.SetActive(false);
    }

    public void OpenSkills()
    {
        shopPanel.SetActive(true);
        HideAll();
        skillsPanel.SetActive(true);
    }

    public void OpenStore()
    {
        shopPanel.SetActive(true);
        HideAll();
        storePanel.SetActive(true);
    }

    public void OpenEquipment()
    {
        shopPanel.SetActive(true);
        HideAll();
        equipmentPanel.SetActive(true);
    }

    public void ExitShop()
    {
        shopPanel.SetActive(false);
    }
}