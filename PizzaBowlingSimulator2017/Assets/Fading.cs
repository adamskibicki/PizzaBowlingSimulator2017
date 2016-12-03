using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fading : MonoBehaviour
{
    public static Fading Instance;
    private Image image;
    // Use this for initialization
    void Start()
    {
        Instance = this;
        image = GetComponentInChildren<Image>();
        FadeIn(3f);
    }
    protected IEnumerator FadeInCoroutine(float fadingSpeed)
    {
        while (image.color.a > 0.01f)
        {
            image.color = Color.Lerp(image.color, new Color(0, 0, 0, 0), fadingSpeed * 0.017f);

            yield return new WaitForSeconds(0.017f);
        }
        image.color = new Color(0, 0, 0, 0);
    }

    public void FadeIn(float fadeTime)
    {
        StartCoroutine(FadeInCoroutine(1 / fadeTime));
    }

    IEnumerator FadeOutCoroutine(float fadingSpeed, Color endColor)
    {
        while (image.color.a < endColor.a - 0.01f)
        {
            image.color = Color.Lerp(image.color, endColor, fadingSpeed * 0.017f);

            yield return new WaitForSeconds(0.017f);
        }
        image.color = endColor;
    }

    public void FadeOut(float fadeTime, Color endColor)
    {
        StartCoroutine(FadeOutCoroutine(1 / fadeTime, endColor));
    }
}
