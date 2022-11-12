using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMakingScene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("음료제조화면");
    }
}
