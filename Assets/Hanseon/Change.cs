using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public Image image;

    public void GameExit()
    {
        StartCoroutine(FadeCorountine());
        Application.Quit();
    }
    public void SceneMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void SceneStart()
    {
        SceneManager.LoadScene("Start");
    }
    IEnumerator FadeCorountine()
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount+=1.0f;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, fadeCount);

        }
    }
}
