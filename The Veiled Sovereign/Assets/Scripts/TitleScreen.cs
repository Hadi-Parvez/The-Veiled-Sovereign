using UnityEngine;
using System.Collections;
using UnityEngine.Video;

public class TitleScreen : MonoBehaviour
{
    [Header("Panels")]
    public GameObject titlePanel;
    public GameObject mainMenuPanel;

    [Header("Canvas Groups")]
    public CanvasGroup videoGroup;
    public CanvasGroup titleText;
    public CanvasGroup pressText;
    public CanvasGroup menuGroup;
    public CanvasGroup fadeOverlay;

    [Header("Video")]
    public VideoPlayer videoPlayer;

    private bool isTransitioning = false;

    void Start()
    {
        titlePanel.SetActive(true);
        mainMenuPanel.SetActive(false);

        videoGroup.alpha = 0;
        titleText.alpha = 0;
        pressText.alpha = 0;

        // Prepare video ONCE
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += OnVideoReady;
    }

    void OnVideoReady(VideoPlayer vp)
    {
        vp.Play(); // start once

        // Start intro AFTER video is running
        StartCoroutine(IntroSequence());
    }

    IEnumerator WaitForVideo()
    {
        while (!videoPlayer.isPrepared)
            yield return null;

        videoPlayer.Play();

        yield return new WaitForSeconds(0.1f);

        yield return StartCoroutine(Fade(videoGroup, 0, 1, 1.5f));

        yield return new WaitForSeconds(0.2f);

        StartCoroutine(Fade(titleText, 0, 1, 0.8f));

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(Fade(pressText, 0, 1, 0.8f));
    }


    IEnumerator IntroSequence()
    {
        // Let video run for a few frames (IMPORTANT)
        yield return new WaitForSeconds(0.15f);

        // Fade in video
        yield return StartCoroutine(Fade(videoGroup, 0, 1, 1.5f));

        yield return new WaitForSeconds(0.2f);

        // Title fade (non-blocking)
        StartCoroutine(Fade(titleText, 0, 1, 0.8f));

        yield return new WaitForSeconds(0.5f);

        // Press text fade
        StartCoroutine(Fade(pressText, 0, 1, 0.8f));
    }

    void Update()
    {
        if (!isTransitioning && Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(TransitionToMenu());
        }
    }

    IEnumerator TransitionToMenu()
    {
        isTransitioning = true;

        float duration = 0.5f;
        float t = 0;

        // 🔴 Fade TO black
        while (t < duration)
        {
            t += Time.unscaledDeltaTime;
            fadeOverlay.alpha = Mathf.Lerp(0, 1, t / duration);
            yield return null;
        }

        fadeOverlay.alpha = 1;

        // Switch panels
        titlePanel.SetActive(false);
        mainMenuPanel.SetActive(true);

        if (videoPlayer != null)
            videoPlayer.Stop();

        // 🔴 Fade FROM black
        t = 0;
        while (t < duration)
        {
            t += Time.unscaledDeltaTime;
            fadeOverlay.alpha = Mathf.Lerp(1, 0, t / duration);
            yield return null;
        }

        fadeOverlay.alpha = 0;
    }

    IEnumerator Fade(CanvasGroup cg, float start, float end, float duration)
    {
        float t = 0;

        while (t < duration)
        {
            t += Time.unscaledDeltaTime;
            cg.alpha = Mathf.Lerp(start, end, t / duration);
            yield return null;
        }

        cg.alpha = end;
    }
}