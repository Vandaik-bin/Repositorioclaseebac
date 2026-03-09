using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;

    GameObject cubo1;
    GameObject cubo2;
    GameObject cubo3;
    GameObject cubo4;
    GameObject cubo5;

    float tiempo = 0;

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = true;

        cubo1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo5 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cubo1.transform.position = new Vector3(-8, 0, 0);
        cubo2.transform.position = new Vector3(-4, 0, 0);
        cubo3.transform.position = new Vector3(0, 0, 0);
        cubo4.transform.position = new Vector3(4, 0, 0);
        cubo5.transform.position = new Vector3(8, 0, 0);





    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate() 
    {
        tiempo += Time.deltaTime;

        if (tiempo > 1f)
        {
            tiempo = 0;

            // GO1
            variable1 = !variable1;

            if (variable1)
                cubo1.GetComponent<Renderer>().material.color = Color.white;
            else
                cubo1.GetComponent<Renderer>().material.color = Color.black;

            // GO2
            variable2 = !variable2;

            if (variable2)
                cubo2.GetComponent<Renderer>().material.color = Color.white;
            else
                cubo2.GetComponent<Renderer>().material.color = Color.black;

            // GO3  (AND)
            variable3 = variable1 && variable2;

            if (variable3)
                cubo3.GetComponent<Renderer>().material.color = Color.white;
            else
                cubo3.GetComponent<Renderer>().material.color = Color.black;

            // GO4 (OR)
            bool resultadoOR = variable1 || variable2;

            if (resultadoOR)
                cubo4.GetComponent<Renderer>().material.color = Color.white;
            else
                cubo4.GetComponent<Renderer>().material.color = Color.black;

            // GO5 (combinación final)
            bool resultadoFinal = variable3 && resultadoOR;

            if (resultadoFinal)
                cubo5.GetComponent<Renderer>().material.color = Color.white;
            else
                cubo5.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}

