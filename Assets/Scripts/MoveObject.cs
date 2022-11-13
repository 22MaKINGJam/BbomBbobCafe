using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public HandlePopup handlePopup;


    public MakeCoffee makeCoffee;// 각 재료를 컵에 담기 위함

    public Vector3 DefaultPos; // 원래 자리
    private bool isClick = false;

    public AudioClip sound_lemnon; // 레몬 슬라이스
    public AudioClip sound_ice_empty; //빈컵에 얼음
    public AudioClip sound_ice_no_empty; //음료에 얼음
    public AudioClip sound_syrup; //시럽
    public AudioClip sound_powder; //가루
    public AudioClip sound_drink; //우유, 물
    public AudioClip sound_sparkling; //탄산수
    public AudioClip sound_cream; //크림

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        makeCoffee = GameObject.Find("Cup").GetComponent<MakeCoffee>(); // 컵 속의 재료에 접근을 위함

        // 원래 자리 저장해놓기
        DefaultPos = this.gameObject.transform.position;

        audioSource = GetComponent<AudioSource>();

        handlePopup = FindObjectOfType<HandlePopup>();

    }
    void Update()
    {
        if (handlePopup.gameObjectPopup.activeSelf)
        {
            isClick = false;
            return;
        }
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
        if (Input.GetMouseButtonDown(0) && isClick && other.gameObject.name == "Cup")
        {
            //Debug.Log("들어옴");
            //Debug.Log(getIngredient().gameObject.name + "컵 위다");
            GameObject tmp = getIngredient().gameObject;
            tmp.SetActive(true); // 활성화
            //Debug.Log(tmp.name=="DecoLemon");
            // 레몬이다
            if (tmp.name == "DecoLemon")
            {
                audioSource.clip = sound_lemnon;
                audioSource.Play();
            }
            // 시럽류이다
            if (tmp.name.Contains("Syrup"))
            {
                audioSource.clip = sound_syrup;
                audioSource.Play();
            }
            // 가루류이다
            if (tmp.name.Contains("Powder"))
            {
                audioSource.clip = sound_powder;
                audioSource.Play();
            }
            // 물, 우유, 샷
            if (tmp.name == "BasicMilk" || tmp.name == "BasicWater" || tmp.name == "BasicShot")
            {
                audioSource.clip = sound_drink;
                audioSource.Play();
            }
            // 탄산수
            if (tmp.name == "BasicSparkling")
            {
                audioSource.clip = sound_sparkling;
                audioSource.Play();
            }
            // 크림
            if (tmp.name == "BasicCream")
            {
                audioSource.clip = sound_cream;
                audioSource.Play();
            }
            // 얼음이다
            if (tmp.name == "BasicIce")
            {
                // 물이 담겼는지?
                if (makeCoffee.isAfterIcedTea || makeCoffee.isAfterGreenTea || makeCoffee.isBasicMilk || makeCoffee.isBasicSparkling || makeCoffee.isBasicWater)
                    audioSource.clip = sound_ice_no_empty;
                else
                    audioSource.clip = sound_ice_empty;
                audioSource.Play();
            }

            transform.position = DefaultPos; // 다시 제자리로
            isClick = false;
        }
    }
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    // 충돌 중일 때 && 컵 위에서 클릭한 경우만 활성화
    //    if (Input.GetMouseButtonDown(0) && isClick && other.gameObject.name == "Cup")
    //    {
    //        //Debug.Log("진행중");
    //        //Debug.Log(getIngredient().gameObject.name + "컵 위다");
    //        getIngredient().gameObject.SetActive(true); // 활성화
    //        transform.position = DefaultPos; // 다시 제자리로
    //        isClick = false;
    //    }
    //}
    //void OnTriggerExit2D(Collider2D other)
    //{
    //    // 충돌 중일 때 && 컵 위에서 클릭한 경우만 활성화
    //    if (Input.GetMouseButtonDown(0) && isClick && other.gameObject.name == "Cup")
    //    {
    //        //Debug.Log("나감");
    //        //Debug.Log(getIngredient().gameObject.name + "컵 위다");
    //        getIngredient().gameObject.SetActive(true); // 활성화
    //        transform.position = DefaultPos; // 다시 제자리로
    //        isClick = false;
    //    }
    //}

    // 지금 컵에 담은 재료를 컵 속에서 활성화 시키기 위해 오브젝트 리턴 
    Transform getIngredient()
    {
        // 컵 속 재료들에 접근해서 지금 이름에 맞는 재료를 리턴
        foreach (Transform child in makeCoffee.transform)
        {
            //Debug.Log(this.transform.name);
            if (child.name == this.transform.name)
                return child;
        }
        return null;
    }

}
