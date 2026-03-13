using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo3 : MonoBehaviour
{
    public GameObject cubo1;
    public GameObject cubo2;

    public bool variable3;

    void Update()
    {
        bool v1 = cubo1.GetComponent<Cubo1>().variable1;
        bool v2 = cubo2.GetComponent<Cubo2>().variable2;

        variable3 = v1 && v2;

        if (variable3)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
}