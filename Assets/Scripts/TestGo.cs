using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestGo : MonoBehaviour
{
    RandomMenu randomMenu;
    // Start is called before the first frame update
    void Start()
    {
        randomMenu= FindObjectOfType<RandomMenu>();
    }
    public void onLoadMake()
    {
        // 메인에서 이렇게 넘어가면 됨
        //GoalCoffee.goal = "CookieBbomBbobLatte";
        Debug.Log(randomMenu.RandomInt);
        if (randomMenu.RandomInt == 1)
            GoalCoffee.goal = "LemonAde";
        if (randomMenu.RandomInt == 2)
            GoalCoffee.goal = "BlueLemonAde";
        if (randomMenu.RandomInt == 3)
            GoalCoffee.goal = "IcedTeano";
        if (randomMenu.RandomInt == 4)
            GoalCoffee.goal = "luckIcedTeano";
        if (randomMenu.RandomInt == 5)
            GoalCoffee.goal = "GreenTeaLatte";
        if (randomMenu.RandomInt == 6)
            GoalCoffee.goal = "LoveGreenTeaLatte";
        if (randomMenu.RandomInt == 7)
            GoalCoffee.goal = "BbomBbobLatte";
        if (randomMenu.RandomInt == 8)
            GoalCoffee.goal = "CookieBbomBbobLatte";

        SceneManager.LoadScene("Make");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
