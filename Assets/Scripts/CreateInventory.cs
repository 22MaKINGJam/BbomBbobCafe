using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateInventory : MonoBehaviour
{
    public GameObject prefab;

    // 처음에 인벤토리 배열해주기
    public GameObject[] objects;
    public int prefabSize;

    // 넣을 스프라이트 배열해주기 바깥에서
    public Sprite[] sprites;

    //간격 입력 받기
    public float spacing;

    /// <summary>
    ///PowderIcedTea // 아이스티
    // PowderLuck // 행운
    // PowderLove  // 사랑

    //DecoLemon  // 레몬슬라이스
    //DecoClover  // 네잎클로버
    // DecoCookie // 뽀삐 쿠키
    //DecoStrawberry  // 통딸기

    //SyrupSea // 바다 시럽
    //SyrupSignature  // 시그니처 시럽
    //SyrupLemon // 레몬 시럽

    //BasicIce  // 얼음
    //BasicCream // 크림폼 샷
    //BasicWater // 물
    //BasicMilk // 우유
    /// </summary>
    /// 
    private string[] PowderName = { "PowderIcedTea", "PowderLuck", "PowderLove", "PowderGreenTea" }; //1층 : 가루
    private string[] DecoName = { "DecoLemon", "DecoClover", "DecoCookie", "DecoStrawberry", "DecoGreenTea" };//2층 : 데코
    private string[] SyrupName = { "SyrupLemon", "SyrupSea", "SyrupSignature" };//3층 : 시럽
    private string[] BasicName01 = { "BasicIce", "BasicCream", "BasicShot" };//4층 : 기본
    private string[] BasicName02 = { "BasicWater", "BasicMilk", "BasicSparkling" };//4층 : 기본

    void Start()
    {
        // 각 층에 맞는 이름 가져오기
        string[] names = getNameArray(this.gameObject.name);

        // 프리팹 사이즈에 맞게 크기 할당
        objects = new GameObject[prefabSize];

        // 오브젝트 뿌리기
        for (int i = 0; i < objects.Length; i++)
        {
            // 간격 1.5
            objects[i] = (GameObject)Instantiate(prefab, new Vector2(transform.position.x + spacing * i, transform.position.y), Quaternion.identity);
            // 부모에 상속 정리
            objects[i].transform.SetParent(this.transform);
            // 오브젝트 이름 부여
            objects[i].transform.gameObject.name = names[i];
            // 스프라이트 부여
            objects[i].gameObject.GetComponent<Image>().sprite = sprites[i];
        }
    }

    private string[] getNameArray(string name)
    {
        // 현재 가루? 데코? 시럽? 베이스?
        switch (name)
        {
            case "Powder": return PowderName;
            case "Deco": return DecoName;
            case "Syrup": return SyrupName;
            case "Basic01": return BasicName01;
            case "Basic02": return BasicName02;
            default: return null;
        }
    }
}
