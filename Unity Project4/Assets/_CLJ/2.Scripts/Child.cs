using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child : MonoBehaviour
{
    public GameObject[] child;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < child.Length; i++)
            {
                child[i].SetActive(true);
            }
        }
    }
}
