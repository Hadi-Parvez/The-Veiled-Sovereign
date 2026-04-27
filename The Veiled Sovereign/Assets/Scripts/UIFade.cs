using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIFade : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public void FadeIn()
    {
        StartCoroutine(Fade(0, 1));
    }


    IEnumerator Fade(float start, float end)
    {
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, end, t);
            yield return null;
        }
    }
}