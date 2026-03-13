using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo1 : MonoBehaviour
{
    public bool variable1;

    float tiempo = 0;

    void Start()
    {
        variable1 = true;
    }

    void FixedUpdate()
    {
        tiempo += Time.deltaTime;

        if (tiempo > 1f)
        {
            tiempo = 0;

            variable1 = !variable1;

            if (variable1)
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