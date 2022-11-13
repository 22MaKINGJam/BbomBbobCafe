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

}

