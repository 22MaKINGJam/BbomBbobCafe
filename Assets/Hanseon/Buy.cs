using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{
    private Transform find;

    public void CanBuy(int money)
    {
        if (money >= 10000)
        {
            find = GameObject.Find("ClothCanvas").transform.Find("Success");
            find.gameObject.SetActive(true);
        }
    }
}
