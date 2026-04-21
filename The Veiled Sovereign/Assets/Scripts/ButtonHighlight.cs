using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject highlight;

    public void OnPointerEnter(PointerEventData eventData)
    {
        foreach (var btn in FindObjectsOfType<ButtonHighlight>())
        {
            btn.highlight.SetActive(false);
            btn.transform.localScale = Vector3.one;
        }

        highlight.SetActive(true);
        transform.localScale = Vector3.one * 1.05f; // slight zoom
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = Vector3.one;
    }
}