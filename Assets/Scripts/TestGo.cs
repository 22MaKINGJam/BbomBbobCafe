using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestGo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }
    public void onLoadMake()
    {
        // 메인에서 이렇게 넘어가면 됨
        GoalCoffee.goal = "CookieBbomBbobLatte";
        SceneManager.LoadScene("Make");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
