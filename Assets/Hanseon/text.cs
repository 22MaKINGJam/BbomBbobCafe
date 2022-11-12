using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    internal string text;
    Transform[] Epilogue2;
    // Start is called before the first frame update
    void Start()
    {
        Epilogue2 = this.GetComponentsInChildren<Transform>();
        foreach (Transform Child in Epilogue2)
        {
            Debug.Log(Child.name);
            Child.gameObject.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
