using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public MakeCoffee makeCoffee;// 각 재료를 컵에 담기 위함

    public Vector3 DefaultPos; // 원래 자리
    private bool isClick = false;

    // Start is called before the first frame update
    void Start()
    {
        makeCoffee = GameObject.Find("Cup").GetComponent<MakeCoffee>(); // 컵 속의 재료에 접근을 위함

        // 원래 자리 저장해놓기
        DefaultPos = this.gameObject.transform.position;

    }
    void Update()
    {
        // 클릭했으면, 내 마우스에 따라다니도록
        if (isClick)
        {
            Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            point.z = gameObject.transform.position.z;
            gameObject.transform.position = point;
        }
    }

    // 드래그 시작
    public void OnMouseDown()
    {
        // 처음 클릭
        if (!isClick)
        {
            isClick = true;
        }
        // 들고 있는 상태에서 다시 클릭
        else
        {
            transform.position = DefaultPos; // 다시 제자리로
            isClick = false;
        }
    }

    // 들어갈 때, 머무를 때 둘 다 인식
    void OnTriggerStay2D(Collider2D other)
    {
        // 충돌 중일 때 && 컵 위에서 클릭한 경우만 활성화
        if (Input.GetMouseButtonDown(0) && isClick&&other.gameObject.name == "Cup")
        {
            //Debug.Log(getIngredient().gameObject.name + "컵 위다");
            getIngredient().gameObject.SetActive(true); // 활성화
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // 충돌 중일 때 && 컵 위에서 클릭한 경우만 활성화
        if (Input.GetMouseButtonDown(0) && isClick && other.gameObject.name == "Cup")
        {
            //Debug.Log(getIngredient().gameObject.name + "컵 위다");
            getIngredient().gameObject.SetActive(true); // 활성화
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        // 충돌 중일 때 && 컵 위에서 클릭한 경우만 활성화
        if (Input.GetMouseButtonDown(0) && isClick && other.gameObject.name == "Cup")
        {
            //Debug.Log(getIngredient().gameObject.name + "컵 위다");
            getIngredient().gameObject.SetActive(true); // 활성화
        }
    }

    // 지금 컵에 담은 재료를 컵 속에서 활성화 시키기 위해 오브젝트 리턴 
    Transform getIngredient()
    {
        // 컵 속 재료들에 접근해서 지금 이름에 맞는 재료를 리턴
        foreach (Transform child in makeCoffee.transform)
        {
            Debug.Log(this.transform.name);
            if (child.name == this.transform.name)
                return child;
        }
        return null;
    }
}
