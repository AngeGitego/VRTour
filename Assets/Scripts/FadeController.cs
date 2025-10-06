using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeController : MonoBehaviour
{
    public CanvasGroup fadePanel;   // Assign your FadePanel CanvasGroup in Inspector
    public float fadeDuration = 1f;

    void Start()
    {
        // Ensure we start transparent
        if (fadePanel != null)
            fadePanel.alpha = 0f;
    }

    public IEnumerator FadeOut()
    {
        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            fadePanel.alpha = Mathf.Clamp01(t / fadeDuration);
            yield return null;
        }
        fadePanel.alpha = 1f;
    }

    public IEnumerator FadeIn()
    {
        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            fadePanel.alpha = 1f - Mathf.Clamp01(t / fadeDuration);
            yield return null;
        }
        fadePanel.alpha = 0f;
    }
}
