using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour
{
    public Text TimeText; //시간 표시하는 텍스트UI
    static float setTime = 180f; //전체 제한시간 설정(초)

    int min; //분단위 변수
    float sec; //초단위 변수



    void Update()
    {
        setTime -= Time.deltaTime; //남은 시간 감소

        if (setTime >= 60)
        {
            min = (int)setTime / 60;
            sec = setTime % 60;

            if (min < 10) //남은시간 10분이하일때
            {
                if (sec < 10)
                {
                    TimeText.text = "0" + min + " : 0" + (int)sec;
                }
                else
                    TimeText.text = "0" + min + " : " + (int)sec;

            }

            if (min >= 10) //10분이상이긴한데 이건 필요없을듯,,,
            {
                TimeText.text = min + " : " + (int)sec;
            }
        }

        if (setTime < 60)
        {
            min = (int)setTime / 60;
            sec = setTime % 60;

            if (sec < 10)
            {
                TimeText.text = "00 : 0" + (int)sec;
            }
            if (sec >= 10)
            {
                TimeText.text = "00 : " + (int)sec;
            }

            if(setTime < 10)
            {
                TimeText.text = "00 : " + (int)sec;
            }
        }

        if (setTime <= 0) // 제한시간 종료시 00분 00초 고정 및 산타옷 구매씬으로 넘어감
        {
            TimeText.text = "00 : 00";
            SceneManager.LoadScene("구매화면");
        }
    }
}