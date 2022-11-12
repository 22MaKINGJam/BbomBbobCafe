using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePopup : MonoBehaviour
{
    public GameObject gameObject; // 팝업창

    // Start is called before the first frame update
    void Start()
    {
    }
    // 팝업 키기
    public void handleOpenPopup()
    {
        Time.timeScale = 0f;

        gameObject.SetActive(true);
    }
    // 팝업 키기
    public void handleClosePopup()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
