using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo5 : MonoBehaviour
{
    public GameObject cubo3;
    public GameObject cubo4;

    public bool resultadoFinal;

    void Update()
    {
        bool v3 = cubo3.GetComponent<Cubo3>().variable3;
        bool v4 = cubo4.GetComponent<Cubo4>().variable4;

        resultadoFinal = v3 && v4;

        if (resultadoFinal)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
}