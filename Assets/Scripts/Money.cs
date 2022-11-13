using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Money : MonoBehaviour
{
    static public Money instance;
    public static int money = 0;

    public Text TimeText; // 돈 표시

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }


    // Update is called once per frame
    void Update()
    {
        TimeText.text = money.ToString();
    }
}
