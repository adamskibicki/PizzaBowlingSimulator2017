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
        StartCoroutine(lessAlphaEnumerator());
    }

    public IEnumerator moreAlphaEnumerator()
    {
        while (true)
        {
            image.color += new Color(image.color.r, image.color.g, image.color.b, image.color.a + 0.07f * 100);
            if (image.color.a >= 1)
                break;
            yield return new WaitForSeconds(0.5f);
        }
    }

    public IEnumerator lessAlphaEnumerator()
    {
        while (true)
        {
            image.color += new Color(image.color.r, image.color.g, image.color.b, image.color.a - 0.07f * 100);
            if (image.color.a <= 0)
                break;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
