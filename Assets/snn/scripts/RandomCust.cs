using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCust : MonoBehaviour
{
    public GameObject cust1;
    public GameObject cust2;
    public GameObject cust3;
    public GameObject cust4;
    public GameObject order;

    public int RandInt;
    public int Randomspawn;

    float OrderTime = 180;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("wait4sec", 0.5f);
        InvokeRepeating("wait4sec", 3f, 4f);
    }

    void wait4sec()
    {
        OrderTime -= Time.deltaTime;
        Randomspawn = Random.Range(1, 5);
        RandInt = Random.Range(1, 8);

        if (Randomspawn == 1 || Randomspawn == 2) //손님 생성
        {
            if ((RandInt == 1 || RandInt == 2) && order.activeSelf == false)
            {
                order.gameObject.SetActive(true);
                cust1.gameObject.SetActive(true);
            }
            else if ((RandInt == 3 || RandInt == 4) && order.activeSelf == false)
            {
                order.gameObject.SetActive(true);
                cust2.gameObject.SetActive(true);
            }

            else if ((RandInt == 5 || RandInt == 6) && order.activeSelf == false)
            {
                order.gameObject.SetActive(true);
                cust3.gameObject.SetActive(true);
            }

            else if ((RandInt == 7) && order.activeSelf == false)
            {
                order.gameObject.SetActive(true);
                cust4.gameObject.SetActive(true);
            }

        }

        else if (Randomspawn == 3 || Randomspawn == 4) //손님 생성x
        {
            Invoke("wait4sec", 4f);
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
