using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCust1 : MonoBehaviour
{
    public GameObject cust1;
    public GameObject cust2;
    public GameObject cust3;
    public GameObject cust4;
    public GameObject order;

    public int RandInt;

    // Start is called before the first frame update
    void Start()
    {
        RandInt = Random.Range(1, 8);
        
        if(RandInt == 1 || RandInt == 2)
        {
            order.gameObject.SetActive(true);
            cust1.gameObject.SetActive(true);
            Debug.Log("asdf1");
        }

        else if (RandInt == 3 || RandInt == 4)
        {
            order.gameObject.SetActive(true);
            cust2.gameObject.SetActive(true);
            Debug.Log("asdf2");
        }

        else if (RandInt == 5 || RandInt == 6)
        {
            order.gameObject.SetActive(true);
            cust3.gameObject.SetActive(true);
            Debug.Log("asdf3");
        }

        else if (RandInt == 7)
        {
            order.gameObject.SetActive(true);
            cust4.gameObject.SetActive(true);
            Debug.Log("asdf4");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
