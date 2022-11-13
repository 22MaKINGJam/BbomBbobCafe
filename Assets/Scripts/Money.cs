using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Money : MonoBehaviour
{
    public static int money=0;
    public Text TimeText; // 돈 표시


    // Update is called once per frame
    void Update()
    {
        TimeText.text = money.ToString();
    }
}
