using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoffee : MonoBehaviour
{
    public Sprite[] sprite; // 미리 정해준 스프라이트에 접근


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(this.GetComponent<Image>().sprite);
        this.GetComponent<Image>().sprite = GetSprite("BlueLemonAde");
        ////GetSprite("재료");
        //back_sky.GetComponent<SpriteRenderer>().sprite = Resources.Load("back_sky", typeof(Sprite)) as Sprite;
    }


    // 원하는 스프라이트 가져오기
    Sprite GetSprite(string name)
    {
        //Debug.Log(menu);
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

        switch (name)
        {
            case "LemonAde": return sprite[0];
            case "BlueLemonAde": return sprite[1];
            case "IcedTeano": return sprite[2];
            case "luckIcedTeano": return sprite[3];
            case "GreenTeaLatte": return sprite[4];
            case "LoveGreenTeaLatte": return sprite[5];
            case "BbomBbobLatte": return sprite[6];
            case "CookieBbomBbobLatte": return sprite[7];
        }
        return null;
    }
}
