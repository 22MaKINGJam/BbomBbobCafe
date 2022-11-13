using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    public static BackgroundSound instansce;
    GameObject BackgroundMusic;
    AudioSource backmusic;

    void Awake()
    {
        if (instansce!=null)
        {
            Destroy(this.gameObject);
        }
        else {
            BackgroundMusic = GameObject.Find("BackgroundSound");
            backmusic = BackgroundMusic.GetComponent<AudioSource>(); //배경음악 저장해둠
            backmusic.Play();
            DontDestroyOnLoad(this.gameObject); //배경음악 계속 재생하게(이후 버튼매니저에서 조작)
            instansce = this;
        }

        //if (backmusic.isPlaying) return; //배경음악이 재생되고 있다면 패스
        //else
        //{
          
        //}
    }
}
