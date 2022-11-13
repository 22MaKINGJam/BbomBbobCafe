using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomMenu : MonoBehaviour
{
    public Image SelectedMenu; //선택된 메뉴를 받을 변수

    public Sprite lemonade;
    public Sprite lemonade_x;
    public Sprite icetino;
    public Sprite icetino_x;
    public Sprite greenlatte;
    public Sprite greenlatte_x;
    public Sprite bblatte;
    public Sprite bblatte_x;

    public int RandomInt;

    void Start()
    {
        RandomInt = Random.Range(1, 9);

        if (RandomInt == 1)
        {
            SelectedMenu.sprite = lemonade;
            //GoalCoffee.goal = "LemonAde";
        }
        else if (RandomInt == 2)
        {
            SelectedMenu.sprite = lemonade_x;
            //GoalCoffee.goal = "BlueLemonAde";
        }
        else if (RandomInt == 3)
        {
            SelectedMenu.sprite = icetino;
            //GoalCoffee.goal = "IcedTeano";
        }
        else if (RandomInt == 4)
        {
            SelectedMenu.sprite = icetino_x;
            //GoalCoffee.goal = "luckIcedTeano";
        }
        else if (RandomInt == 5)
        {
            SelectedMenu.sprite = greenlatte;
            //GoalCoffee.goal = "GreenTeaLatte";
        }
        else if (RandomInt == 6)
        {
            SelectedMenu.sprite = greenlatte_x;
            //GoalCoffee.goal = "LoveGreenTeaLatte";
        }
        else if (RandomInt == 7)
        {
            SelectedMenu.sprite = bblatte;
            //GoalCoffee.goal = "BbomBbobLatte";
        }
        else if (RandomInt == 8)
        {
            SelectedMenu.sprite = bblatte_x;
            //GoalCoffee.goal = "CookieBbomBbobLatte";
        }

    }

    /* Update is called once per frame
    void Update()
    {
        RandomInt = Random.Range(1, 9);
    }*/

}
