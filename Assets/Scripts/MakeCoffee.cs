using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCoffee : MonoBehaviour
{
    /// <summary>
    /// 반짝반짝 레몬에이드 : LemonAde
    /// 특별레시피 +)<바다향 폴폴 블루레몬에이드> : BlueLemonAde
    /// 달콤쌉싸름 아이스티노(ice only) : IcedTeano
    /// 특별레시피)<행운 한스푼 아이스티노> : luckIcedTeano
    /// 뽀미가 좋아하는 이화그린라떼(ice only) : GreenTeaLatte
    /// 특별레시피)뽀미의 사랑 가득 이화그린라떼 : LoveGreenTeaLatte
    /// 뽀삐가 좋아하는 뽐뽑라떼(ice/hot) : BbomBbobLatte
    /// 특별레시피)뽀삐쿠키가 올라간 뽐뽑라떼 : CookieBbomBbobLatte
    /// </summary>
    public string goalCoffee = "";

    //속 재료 활성, 비활성
    private GameObject ingredient;

    public bool isPowderIcedTea = false; // 아이스티
    public bool isPowderLuck = false; // 행운
    public bool isPowderLove = false; // 사랑
    public bool isPowderGreenTea = false; // 녹차

    public bool isDecoLemon = false;  // 레몬슬라이스
    public bool isDecoClover = false; // 네잎클로버
    public bool isDecoCookie = false; // 뽀삐 쿠키 
    public bool isDecoStrawberry = false; // 통딸기
    public bool isDecoGreenTea = false; // 녹찻잎

    public bool isSyrupSea = false; // 바다 시럽
    public bool isSyrupSignature = false; // 시그니처 시럽
    public bool isSyrupLemon = false; // 레몬 시럽

    public bool isBasicIce = false; // 얼음
    public bool isBasicCream = false; // 크림폼
    public bool isBasicShot = false; // 샷
    public bool isBasicWater = false; // 물
    public bool isBasicMilk = false; // 우유
    public bool isBasicSparkling = false; // 탄산수

    public bool isAfterIcedTea = false; // 물 + 아이스티
    public bool isAfterGreenTea = false; // 우유 + 녹차가루

    //PowderIcedTea, PowderLuck, PowderLove, PowderGreenTea
    // DecoLemon, DecoClover, DecoCookie, DecoStrawberry, DecoGreenTea
    //SyrupSea, SyrupSignature, SyrupLemon
    //BasicIce, BasicCream, BasicShot, BasicWater, BasicMilk, BasicSparkling

    // 전체
    public string[] allIngredients = { "PowderIcedTea", "PowderLuck", "PowderLove" };

    // 파우더
    public string[] powders = { "PowderIcedTea", "PowderLuck", "PowderLove", "PowderGreenTea" };

    public string[] tests = { "PowderIcedTea" };
    // 레시피
    public string[] LemonAde = { "DecoLemon", "SyrupLemon", "BasicIce", "BasicSparkling" };
    public string[] BlueLemonAde = { "DecoLemon", "SyrupSea", "SyrupLemon", "BasicIce", "BasicSparkling" };

    public string[] IcedTeano = { "PowderIcedTea", "BasicIce", "BasicWater", "BasicShot" };
    public string[] luckIcedTeano = { "DecoClover", "PowderLuck", "PowderIcedTea", "BasicIce", "BasicWater", "BasicShot" };

    public string[] GreenTeaLatte = { "PowderGreenTea", "DecoGreenTea", "BasicIce", "BasicMilk" };
    public string[] LoveGreenTeaLatte = { "PowderGreenTea", "DecoGreenTea", "BasicIce", "BasicMilk", "PowderLove", "DecoStrawberry" };

    public string[] BbomBbobLatte = { "BasicIce", "BasicMilk", "BasicCream", "BasicShot", "SyrupSignature" };
    public string[] CookieBbomBbobLatte = { "BasicIce", "BasicMilk", "DecoCookie", "BasicCream", "BasicShot", "SyrupSignature" };


    //Start is called before the first frame update
    void Start()
    {
        ingredient = this.gameObject;
        goalCoffee = GoalCoffee.goal;
    }
    // Update is called once per frame
    void Update()
    {
        // 활성화 되었는지 확인

        // 하지말고..MoveObject에서 setActive하기
        //Debug.Log(ingredient.Find("PowderIcedTea").gameObject.activeSelf); // 활성화 되어있는지 확인
        //this.transform.Find("PowderIcedTea").gameObject.SetActive(isPowderIcedTea);
        //this.transform.Find("PowderLuck").gameObject.SetActive(isPowderLuck);
        //this.transform.Find("PowderLove").gameObject.SetActive(isPowderLove);

        //this.transform.Find("DecoCookie").gameObject.SetActive(isDecoCookie);
        //this.transform.Find("DecoStrawberry").gameObject.SetActive(isDecoStrawberry);
        //this.transform.Find("DecoClover").gameObject.SetActive(isDecoClover);
        //this.transform.Find("DecoLemon").gameObject.SetActive(isDecoLemon);

        //this.transform.Find("SyrupSea").gameObject.SetActive(isSyrupSea);
        //this.transform.Find("SyrupSignature").gameObject.SetActive(isSyrupSignature);
        //this.transform.Find("SyrupLemon").gameObject.SetActive(isSyrupLemon);

        //this.transform.Find("BasicIce").gameObject.SetActive(isBasicIce);
        //this.transform.Find("BasicCream").gameObject.SetActive(isBasicCream);
        //this.transform.Find("BasicWater").gameObject.SetActive(isBasicWater);
        //this.transform.Find("BasicMilk").gameObject.SetActive(isBasicMilk);



        isPowderIcedTea = this.transform.Find("PowderIcedTea").gameObject.activeSelf;
        isPowderLuck = this.transform.Find("PowderLuck").gameObject.activeSelf;
        isPowderLove = this.transform.Find("PowderLove").gameObject.activeSelf;
        isPowderGreenTea = this.transform.Find("PowderGreenTea").gameObject.activeSelf;

        isDecoLemon = this.transform.Find("DecoLemon").gameObject.activeSelf;
        isDecoClover = this.transform.Find("DecoClover").gameObject.activeSelf;
        isDecoCookie = this.transform.Find("DecoCookie").gameObject.activeSelf;
        isDecoStrawberry = this.transform.Find("DecoStrawberry").gameObject.activeSelf;
        isDecoGreenTea = this.transform.Find("DecoGreenTea").gameObject.activeSelf;

        isSyrupSea = this.transform.Find("SyrupSea").gameObject.activeSelf;
        isSyrupSignature = this.transform.Find("SyrupSignature").gameObject.activeSelf;
        isSyrupLemon = this.transform.Find("SyrupLemon").gameObject.activeSelf;

        isBasicIce = this.transform.Find("BasicIce").gameObject.activeSelf;
        isBasicCream = this.transform.Find("BasicCream").gameObject.activeSelf;
        isBasicShot = this.transform.Find("BasicShot").gameObject.activeSelf;
        isBasicWater = this.transform.Find("BasicWater").gameObject.activeSelf;
        isBasicMilk = this.transform.Find("BasicMilk").gameObject.activeSelf;
        isBasicSparkling = this.transform.Find("BasicSparkling").gameObject.activeSelf;

        // 물+아이스티가루
        if (isBasicWater && isPowderIcedTea)
        {
            this.transform.Find("PowderIcedTea").gameObject.SetActive(false);
            this.transform.Find("BasicWater").gameObject.SetActive(false);
            this.transform.Find("AfterIcedTea").gameObject.SetActive(true);
        }
        //우유+녹차가루
        if (isBasicMilk && isPowderGreenTea)
        {
            this.transform.Find("BasicMilk").gameObject.SetActive(false);
            this.transform.Find("PowderGreenTea").gameObject.SetActive(false);
            this.transform.Find("AfterGreenTea").gameObject.SetActive(true);
        }
        isAfterIcedTea = this.transform.Find("AfterIcedTea").gameObject.activeSelf;
        isAfterGreenTea = this.transform.Find("AfterGreenTea").gameObject.activeSelf;
    }
}
