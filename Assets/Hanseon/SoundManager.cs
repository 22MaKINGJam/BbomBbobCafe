using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicsource;
    public AudioSource btnsource;

    public void SetMusicVolume(float volume)//BGM조절함수
    {
        musicsource.volume = volume;
    }

    public void SetSfxVolume(float volume)//효과음조절함수
    {
        btnsource.volume = volume;
    }

    public void OnSfx()
    {
        btnsource.Play();//오디오를 재생하는 함수
    }

    static public SoundManager instance;

    public AudioClip[] clips;// 배경음악들

    private AudioSource audioSource;

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);

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

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // 재생 함수
    public void Play(int _playMusicTrack)
    {
        audioSource.volume = 1f; // 항상 바로 재생!
        audioSource.clip = clips[_playMusicTrack];
        audioSource.Play();
    }
    public void Stop(int _playMusicTrack)
    {
        audioSource.Stop();
    }


    public void FadeOutMusic()
    {
        StopAllCoroutines(); // 페이드인 아웃 동시에 실행되면 꼬이니까 방지를 위해
        StartCoroutine(FadeOutMusicCoroutine());
    }

    IEnumerator FadeOutMusicCoroutine()
    {
        for (float i = 1.0f; i >= 0f; i -= 0.01f)
        {
            audioSource.volume = i;
            yield return waitTime;
        }
    }

    public void FadeInMusic()
    {
        StopAllCoroutines(); // 페이드인 아웃 동시에 실행되면 꼬이니까 방지를 위해
        StartCoroutine(FadeInMusicCoroutine());
    }

    IEnumerator FadeInMusicCoroutine()
    {
        for (float i = 1.0f; i <= 1f; i += 0.01f)
        {
            audioSource.volume = i;
            yield return waitTime;
        }
    }

}
