using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    private UnityEngine.UI.Text text;
    float n;

    void Start()
    {
        text = GetComponent<UnityEngine.UI.Text>();
        StartCoroutine(FadeTextToFullAlpha());

    }
    private void Update()
    {

    }

    public IEnumerator FadeTextToFullAlpha() // 알파값 0에서 1로 전환
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        while (text.color.a < 1.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + (Time.deltaTime / 2.0f));
            yield return null;
        }

    }



}
