using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitCoffee : MonoBehaviour
{
    // MakeCoffee 에서 목표 음료 가져오기
    public MakeCoffee makeCoffee;

    // Start is called before the first frame update
    void Start()
    {
        // 활성화 되어있는지 접근하기 위함
        makeCoffee = FindObjectOfType<MakeCoffee>();
    }

    // 버튼 클릭 시 실행
    public void JudgeCoffee()
    {
        if (getRecipe())
            Debug.Log("성공! 돈 올리기");
        else
            Debug.Log("실패! 돈 안 올림");

        // 메인화면으로
        onLoadMain();
    }

    public void onLoadMain() {
        SceneManager.LoadScene("Main");
    }

    public bool getRecipe()
    {
        //public bool isPowderIcedTea = false; // 아이스티
        //public bool isPowderLuck = false; // 행운
        //public bool isPowderLove = false; // 사랑
        //public bool isPowderGreenTea = false; // 녹차

        //public bool isDecoLemon = false;  // 레몬슬라이스
        //public bool isDecoClover = false; // 네잎클로버
        //public bool isDecoCookie = false; // 뽀삐 쿠키 
        //public bool isDecoStrawberry = false; // 통딸기
        //public bool isDecoGreenTea = false; // 녹찻잎

        //public bool isSyrupSea = false; // 바다 시럽
        //public bool isSyrupSignature = false; // 시그니처 시럽
        //public bool isSyrupLemon = false; // 레몬 시럽

        //public bool isBasicIce = false; // 얼음
        //public bool isBasicCream = false; // 크림폼
        //public bool isBasicShot = false; // 샷
        //public bool isBasicWater = false; // 물
        //public bool isBasicMilk = false; // 우유
        //public bool isBasicSparkling = false; // 탄산수

        //if (
        //    !makeCoffee.isPowderIcedTea &&
        //   !makeCoffee.isPowderLuck &&
        //    !makeCoffee.isPowderLove &&
        //     !makeCoffee.isPowderGreenTea &&
        //     !makeCoffee.isDecoLemon &&
        //     !makeCoffee.isDecoClover &&
        //     !makeCoffee.isDecoCookie &&
        //     !makeCoffee.isDecoStrawberry &&
        //    !makeCoffee.isDecoGreenTea &&
        //    !makeCoffee.isSyrupSea &&
        //    !makeCoffee.isSyrupSignature &&
        //    !makeCoffee.isSyrupLemon &&
        //     !makeCoffee.isBasicIce &&
        //     !makeCoffee.isBasicCream &&
        //     !makeCoffee.isBasicShot &&
        //    !makeCoffee.isBasicWater &&
        //    !makeCoffee.isBasicMilk &&
        //     !makeCoffee.isBasicSparkling
        //    )

        //반짝반짝 레몬에이드
        if (makeCoffee.goalCoffee == "LemonAde")
        {
            if (
                !makeCoffee.isPowderIcedTea &&
               !makeCoffee.isPowderLuck &&
                !makeCoffee.isPowderLove &&
                 !makeCoffee.isPowderGreenTea &&
                 makeCoffee.isDecoLemon &&
                 !makeCoffee.isDecoClover &&
                 !makeCoffee.isDecoCookie &&
                 !makeCoffee.isDecoStrawberry &&
                !makeCoffee.isDecoGreenTea &&
                !makeCoffee.isSyrupSea &&
                !makeCoffee.isSyrupSignature &&
                makeCoffee.isSyrupLemon &&
                 makeCoffee.isBasicIce &&
                 !makeCoffee.isBasicCream &&
                 !makeCoffee.isBasicShot &&
                !makeCoffee.isBasicWater &&
                !makeCoffee.isBasicMilk &&
                 makeCoffee.isBasicSparkling
                ) return true;
            else return false;
        }
        //바다향 폴폴 레몬에이드
        if (makeCoffee.goalCoffee == "BlueLemonAde")
        {
            if (
                !makeCoffee.isPowderIcedTea &&
               !makeCoffee.isPowderLuck &&
                !makeCoffee.isPowderLove &&
                 !makeCoffee.isPowderGreenTea &&
                 makeCoffee.isDecoLemon &&
                 !makeCoffee.isDecoClover &&
                 !makeCoffee.isDecoCookie &&
                 !makeCoffee.isDecoStrawberry &&
                !makeCoffee.isDecoGreenTea &&
                makeCoffee.isSyrupSea &&
                !makeCoffee.isSyrupSignature &&
                makeCoffee.isSyrupLemon &&
                 makeCoffee.isBasicIce &&
                 !makeCoffee.isBasicCream &&
                 !makeCoffee.isBasicShot &&
                !makeCoffee.isBasicWater &&
                !makeCoffee.isBasicMilk &&
                 makeCoffee.isBasicSparkling
                ) return true;
            else return false;
        }
        //달콤쌉싸름 아이스티노
        if (makeCoffee.goalCoffee == "IcedTeano")
        {
            if (
                makeCoffee.isPowderIcedTea &&
               !makeCoffee.isPowderLuck &&
                !makeCoffee.isPowderLove &&
                 !makeCoffee.isPowderGreenTea &&
                 !makeCoffee.isDecoLemon &&
                 !makeCoffee.isDecoClover &&
                 !makeCoffee.isDecoCookie &&
                 !makeCoffee.isDecoStrawberry &&
                !makeCoffee.isDecoGreenTea &&
                !makeCoffee.isSyrupSea &&
                !makeCoffee.isSyrupSignature &&
                !makeCoffee.isSyrupLemon &&
                 makeCoffee.isBasicIce &&
                 !makeCoffee.isBasicCream &&
                 makeCoffee.isBasicShot &&
                makeCoffee.isBasicWater &&
                !makeCoffee.isBasicMilk &&
                 !makeCoffee.isBasicSparkling
                ) return true;
            else return false;
        }
        //행운 한스푼 아이스티노
        if (makeCoffee.goalCoffee == "luckIcedTeano")
        {
            if (
                makeCoffee.isPowderIcedTea &&
               makeCoffee.isPowderLuck &&
                !makeCoffee.isPowderLove &&
                 !makeCoffee.isPowderGreenTea &&
                 !makeCoffee.isDecoLemon &&
                 makeCoffee.isDecoClover &&
                 !makeCoffee.isDecoCookie &&
                 !makeCoffee.isDecoStrawberry &&
                !makeCoffee.isDecoGreenTea &&
                !makeCoffee.isSyrupSea &&
                !makeCoffee.isSyrupSignature &&
                !makeCoffee.isSyrupLemon &&
                 makeCoffee.isBasicIce &&
                 !makeCoffee.isBasicCream &&
                 makeCoffee.isBasicShot &&
                makeCoffee.isBasicWater &&
                !makeCoffee.isBasicMilk &&
                 !makeCoffee.isBasicSparkling
                ) return true;
            else return false;
        }
        //이화그린 라떼
        if (makeCoffee.goalCoffee == "GreenTeaLatte")
        {

            if (
                !makeCoffee.isPowderIcedTea &&
               !makeCoffee.isPowderLuck &&
                !makeCoffee.isPowderLove &&
                 makeCoffee.isPowderGreenTea &&
                 !makeCoffee.isDecoLemon &&
                 !makeCoffee.isDecoClover &&
                 !makeCoffee.isDecoCookie &&
                 !makeCoffee.isDecoStrawberry &&
                makeCoffee.isDecoGreenTea &&
                !makeCoffee.isSyrupSea &&
                !makeCoffee.isSyrupSignature &&
                !makeCoffee.isSyrupLemon &&
                 makeCoffee.isBasicIce &&
                 !makeCoffee.isBasicCream &&
                 !makeCoffee.isBasicShot &&
                !makeCoffee.isBasicWater &&
                makeCoffee.isBasicMilk &&
                 !makeCoffee.isBasicSparkling
                ) return true;
            else return false;
        }

        //이화그린 라떼
        if (makeCoffee.goalCoffee == "LoveGreenTeaLatte")
        {

            if (
                !makeCoffee.isPowderIcedTea &&
               !makeCoffee.isPowderLuck &&
                makeCoffee.isPowderLove &&
                 makeCoffee.isPowderGreenTea &&
                 !makeCoffee.isDecoLemon &&
                 !makeCoffee.isDecoClover &&
                 !makeCoffee.isDecoCookie &&
                 makeCoffee.isDecoStrawberry &&
                makeCoffee.isDecoGreenTea &&
                !makeCoffee.isSyrupSea &&
                !makeCoffee.isSyrupSignature &&
                !makeCoffee.isSyrupLemon &&
                 makeCoffee.isBasicIce &&
                 !makeCoffee.isBasicCream &&
                 !makeCoffee.isBasicShot &&
                !makeCoffee.isBasicWater &&
                makeCoffee.isBasicMilk &&
                 !makeCoffee.isBasicSparkling
                ) return true;
            else return false;
        }
        // 뽐뽑라떼
        if (makeCoffee.goalCoffee == "BbomBbobLatte")
        {

            if (
                !makeCoffee.isPowderIcedTea &&
               !makeCoffee.isPowderLuck &&
                !makeCoffee.isPowderLove &&
                 !makeCoffee.isPowderGreenTea &&
                 !makeCoffee.isDecoLemon &&
                 !makeCoffee.isDecoClover &&
                 !makeCoffee.isDecoCookie &&
                 !makeCoffee.isDecoStrawberry &&
                !makeCoffee.isDecoGreenTea &&
                !makeCoffee.isSyrupSea &&
                makeCoffee.isSyrupSignature &&
                !makeCoffee.isSyrupLemon &&
                 makeCoffee.isBasicIce &&
                 makeCoffee.isBasicCream &&
                 !makeCoffee.isBasicShot &&
                !makeCoffee.isBasicWater &&
                makeCoffee.isBasicMilk &&
                 !makeCoffee.isBasicSparkling
                ) return true;
            else return false;
        }
        // 뽐뽑라떼
        if (makeCoffee.goalCoffee == "CookieBbomBbobLatte")
        {

            if (
                !makeCoffee.isPowderIcedTea &&
               !makeCoffee.isPowderLuck &&
                !makeCoffee.isPowderLove &&
                 !makeCoffee.isPowderGreenTea &&
                 !makeCoffee.isDecoLemon &&
                 !makeCoffee.isDecoClover &&
                 makeCoffee.isDecoCookie &&
                 !makeCoffee.isDecoStrawberry &&
                !makeCoffee.isDecoGreenTea &&
                !makeCoffee.isSyrupSea &&
                makeCoffee.isSyrupSignature &&
                !makeCoffee.isSyrupLemon &&
                 makeCoffee.isBasicIce &&
                 makeCoffee.isBasicCream &&
                 !makeCoffee.isBasicShot &&
                !makeCoffee.isBasicWater &&
                makeCoffee.isBasicMilk &&
                 !makeCoffee.isBasicSparkling
                ) return true;
            else return false;
        }
        return false;
    }
    //// 메뉴에 맞는 레시피를 리턴
    //private string[] GetRecipe(string menu)
    //{
    //    //Debug.Log(menu);
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
    //    //string[] temp= { };

    //    switch ((string)menu)
    //    {
    //        case "LemonAde": return new string[] { "PowderIcedTea" };
    //        case "BlueLemonAde": return new string[] { "ice", "water" };
    //        case "IcedTeano": return new string[] { "ice", "water" };
    //        case "luckIcedTeano": return new string[] { "ice", "water" };
    //        case "StrawberryLatte": return new string[] { "ice", "water" };
    //        case "LoveStrawberryLatte": return new string[] { "ice", "water" };
    //        case "BbomBbobLatte": return new string[] { "ice", "water" };
    //        case "CookieBbomBbobLatte": return new string[] { "ice", "water" };
    //    }
    //    return new string[] { };
    //}
}
