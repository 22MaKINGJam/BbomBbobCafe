using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    private Transform find;
    public GameObject happy;
    public GameObject gameui;
    public AudioSource SuccessSound;

    public void CanBuy(int money)
    {
        if (money >= 10000)
        {
            find = GameObject.Find("ClothCanvas").transform.Find("Success");

            find.gameObject.SetActive(true);
            happy.gameObject.SetActive(true);
            gameui.gameObject.SetActive(false);
            SuccessSound.Play();
        }
    }
}
