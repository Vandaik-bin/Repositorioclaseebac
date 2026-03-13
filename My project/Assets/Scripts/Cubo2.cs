using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo2 : MonoBehaviour
{
    public bool variable2;

    float tiempo = 0;

    void Start()
    {
        variable2 = false;
    }

    void FixedUpdate()
    {
        tiempo += Time.deltaTime;

        if (tiempo > 1f)
        {
            tiempo = 0;

            variable2 = !variable2;

            if (variable2)
            {
                GetComponent<Renderer>().material.color = Color.white;
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.black;
            }
        }
    }
}