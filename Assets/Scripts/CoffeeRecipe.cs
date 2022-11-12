using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoffeeRecipe : MonoBehaviour
{
    private int NUMBER = 6;
    public GameObject prefab; // 레시피 재료 프리팹

    private GameObject[] objects; // 처음에 배열해주기
    private int prefabSize;


    //완성본 이미지
    public Sprite[] goalCoffeeSprites;
    //재료 이미지
    public Sprite[] ingredientSprites;

    // 완성할 커피의 설명
    public string description;

    //        case "LemonAde": return sprite[0];
    //case "BlueLemonAde": return sprite[1];
    //case "IcedTeano": return sprite[2];
    //case "luckIcedTeano": return sprite[3];
    //case "GreenTeaLatte": return sprite[4];
    //case "LoveGreenTeaLatte": return sprite[5];
    //case "BbomBbobLatte": return sprite[6];
    //case "CookieBbomBbobLatte": return sprite[7];

    private int[] LemonAdeIngredients = { 4, 9, 12, 17 };
    private int[] BlueLemonAdeIngredients = { 4, 9, 10, 12, 17 };
    private int[] IcedTeanoIngredients = { 0, 12, 14, 15 };
    private int[] luckIcedTeanoIngredients = { 0, 1, 5, 12, 14, 15 };
    private int[] GreenTeaLatteIngredients = { 3, 8, 12, 16 };
    private int[] LoveGreenTeaLatteIngredients = { 2, 3, 7, 8, 12, 16 };
    private int[] BbomBbobLatteIngredients = { 10, 13, 14, 16 };
    private int[] CookieBbomBbobLatteIngredients = { 6, 10, 12, 13, 14, 16 };

    // Start is called before the first frame update
    void Start()
    {
        //Text에 접근 못하는 에러가 생겨서... 어쩔 수 없이 setActive로!

        //Debug.Log(handlePopup.gameObject);
        //Debug.Log(GameObject.Find("RecipePopup/Popup/Name").GetComponent<Text>());

        objects = new GameObject[NUMBER];//할당

        // 우선 빈 상자 오브젝트 뿌리기
        for (int i = 0; i < NUMBER; i++)
        {
            // 간격 1.5
            objects[i] = (GameObject)Instantiate(prefab, new Vector2(transform.position.x + 1.55f * i - 3.85f, transform.position.y - 2.15f), Quaternion.identity);
            // 오브젝트 이름 부여
            //objects[i].transform.gameObject.name = names[i];
            // 부모에 상속 정리
            //objects[i].transform.SetParent(this.transform);
            objects[i].transform.SetParent(this.transform.Find("Ingredients"));
        }
        //objects[i].gameObject.GetComponent<Image>().sprite = sprites[i];

        if (GoalCoffee.goal == "LemonAde")
        {
            setRecipe("LemonAde", LemonAdeIngredients, 0);
        }
        if (GoalCoffee.goal == "BlueLemonAde")
        {
            setRecipe("BlueLemonAde", BlueLemonAdeIngredients, 1);
        }
        if (GoalCoffee.goal == "IcedTeano")
        {
            setRecipe("IcedTeano", IcedTeanoIngredients, 2);
        }
        if (GoalCoffee.goal == "luckIcedTeano")
        {
            setRecipe("luckIcedTeano", luckIcedTeanoIngredients, 3);
        }
        if (GoalCoffee.goal == "GreenTeaLatte")
        {
            setRecipe("GreenTeaLatte", GreenTeaLatteIngredients, 4);
        }
        if (GoalCoffee.goal == "LoveGreenTeaLatte")
        {
            setRecipe("LoveGreenTeaLatte", LoveGreenTeaLatteIngredients, 5);
        }
        if (GoalCoffee.goal == "BbomBbobLatte")
        {
            setRecipe("BbomBbobLatte", BbomBbobLatteIngredients, 6);
        }
        if (GoalCoffee.goal == "CookieBbomBbobLatte")
        {
            setRecipe("CookieBbomBbobLatte", CookieBbomBbobLatteIngredients, 7);
        }
    }

    void setRecipe(string goalName, int[] infoArr, int idx)
    {
        this.transform.Find("CoffeeInfo").Find(goalName + "Info").gameObject.SetActive(true);
        this.transform.Find("GoalCoffee").GetComponent<Image>().sprite = goalCoffeeSprites[idx];// 최종
        for (int i = 0; i < infoArr.Length; i++)
        {
            objects[i].transform.GetChild(0).gameObject.GetComponent<Image>().sprite = ingredientSprites[infoArr[i]];// 재료
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (handlePopup.gameObject.activeSelf)
        //    Debug.Log(this.transform.Find("CoffeeName").GetComponent<Text>().text);
    }
}
