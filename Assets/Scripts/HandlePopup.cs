using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePopup : MonoBehaviour
{
    public GameObject gameObjectPopup; // 팝업창

    public AudioClip openCloseSound; // 열릴 때 닫힐 때 소리
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // 팝업 키기
    public void handleOpenPopup()
    {
        audioSource.clip = openCloseSound;
        audioSource.Play();
        Time.timeScale = 0f;
        gameObjectPopup.SetActive(true);

    }
    // 팝업 키기
    public void handleClosePopup()
    {
        audioSource.clip = openCloseSound;
        audioSource.Play();
        Time.timeScale = 1f;
        gameObjectPopup.SetActive(false);

    }
}
