using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCoffee : MonoBehaviour
{
    public MakeCoffee makeCoffee;// 각 재료를 컵에 담기 위함

    // Start is called before the first frame update
    void Start()
    {
        makeCoffee = GameObject.Find("Cup").GetComponent<MakeCoffee>(); // 컵 속의 재료에 접근을 위함
    }

    // 커피 초기화
    public void HandleInitCoffee()
    {
        // 컵 속 재료들에 접근해서 지금 이름에 맞는 재료를 리턴
        foreach (Transform child in makeCoffee.transform)
        {
                child.gameObject.SetActive(false);
        }

    }
}
