using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildSearch: MonoBehaviour
{
    Transform[] Scene2;
    private float Time = 0f;
    void Start()
    {
        foreach (Transform Child in this.transform)
        {
            Child.gameObject.SetActive(true);
            StartCoroutine("timeCoroutine");
        }

    }

    IEnumerator testCoroutine()
    {
        while (true)
        {
            Debug.Log("Do Something");
            yield return new WaitForSeconds(5f);
        }
    }
}
