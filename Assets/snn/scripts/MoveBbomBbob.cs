using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBbomBbob : MonoBehaviour
{
    public GameObject bbom1;
    public GameObject bbom2;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("bbmove", 0.2f);
        InvokeRepeating("bbmove", 0.5f, 0.5f);
    }


    void bbmove()
    {
        if (bbom1.gameObject.activeSelf == true)
        {
            bbom1.gameObject.SetActive(false);
            bbom2.gameObject.SetActive(true);
        }
        else if(bbom1.gameObject.activeSelf == false)
        {
            bbom2.gameObject.SetActive(false);
            bbom1.gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
