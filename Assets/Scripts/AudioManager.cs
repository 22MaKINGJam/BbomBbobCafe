using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public AudioMixer mixer;
    public Slider BGMSlider;// 배경음악
    public Slider effectSlider;// 효과음
    //public Image volumeMute;

    private float volume; // 볼륨

    //public void Start()
    //{
    //    if (backSlider != null) backSlider.value = data.background;
    //    if (effectSlider != null) effectSlider.value = data.effect;
    //}

    public void BGMControl()
    {
        volume = BGMSlider.value;

        mixer.SetFloat("BGM", volume);

        ////data.background = volume;
        //if (!data.mute)
        //{
        //    mixer.SetFloat("background", volume);
        //}
    }

    //public void effectControl()
    //{

    //    volume = effectSlider.value;
    //    data.effect = volume;

    //    if (!data.mute)
    //    {
    //        mixer.SetFloat("effect", volume);
    //    }

    //}

    //public void volumeControl()
    //{
    //    if (data.mute)
    //    {
    //        //data.mute = !data.mute;
    //        //volumeMute.sprite = Resources.Load<Sprite>("UI/음향 on");
    //        mixer.SetFloat("background", data.background);
    //        mixer.SetFloat("effect", data.effect);
    //    }
    //    else
    //    {
    //        //data.mute = !data.mute;
    //        //volumeMute.sprite = Resources.Load<Sprite>("UI/음향 off");
    //        mixer.SetFloat("background", -80f);
    //        mixer.SetFloat("effect", -80f);
    //    }
    //}
}