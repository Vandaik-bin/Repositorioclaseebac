using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo4 : MonoBehaviour
{
    public GameObject cubo1;
    public GameObject cubo2;

    public bool variable4;

    void Update()
    {
        bool v1 = cubo1.GetComponent<Cubo1>().variable1;
        bool v2 = cubo2.GetComponent<Cubo2>().variable2;

        variable4 = v1 || v2;

        if (variable4)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
}