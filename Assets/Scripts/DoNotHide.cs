using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotHide : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
