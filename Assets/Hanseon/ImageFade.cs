using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFade : MonoBehaviour
{
    private UnityEngine.UI.Image image;

    void Awake()
    {
        image = GetComponent<Image>();
        StartCoroutine(FadeTextToZero());
    }

    public IEnumerator FadeImageToFullAlpha() // 알파값 0에서 1로 전환
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
        while (image.color.a < 1.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }
        StartCoroutine(FadeTextToZero());
    }

    public IEnumerator FadeTextToZero()  // 알파값 1에서 0으로 전환
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
        while (image.color.a > 0.0f)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a - (Time.deltaTime / 2.0f));
            yield return null;
        }
        StartCoroutine(FadeImageToFullAlpha());
    }
}
