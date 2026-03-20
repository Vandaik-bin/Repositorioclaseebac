using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int contador = 0;
    float valor = 1f;

    float a = 6.3f;
    float b = 3.7f;

    public string ColorTexto = "negro";

    string Contra = "arbol perro piano tonto";


    // Start is called before the first frame update
    void Start()
    {
        float Result = a + b;
        int Resulte = (int)Result;

        Debug.Log("Result :" + Result);
        Debug.Log("Resiltado int:" + Resulte);

        string texto = Result.ToString("F4");
        Debug.Log("Float con 4 decimales" + texto);

        string palabra1 = Contra.Substring(0,5);
        string palabra2 = Contra.Substring(6,5);
        string palabra3 = Contra.Substring(12,5);
        string palabra4 = Contra.Substring(18);

        string[] piezas = Contra.Split(' ');
        foreach (string pieza in piezas)
        {
            Debug.Log(pieza);
        }

        string num1 = "10";
        string num2 = "5";

        int n1 = int.Parse(num1);
        int n2 = int.Parse(num2);

        int suma = n1 + n2;
        Debug.Log("Suma parseada: " + suma);

        for (int i = 0; i < Contra.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Indice par: " + Contra[i]);
            }
        }

        string recortado = Contra.Substring(0, Contra.Length - 5);
        Debug.Log("String recortado: " + recortado);

    }

    // Update is called once per frame
    void Update()
    {
        contador++;
    }

    void FixedUpdate()
    {
        valor *= 1.1f;

        if (contador % 2  == 0)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        switch (ColorTexto)
        {
            case "negro":
                GetComponent<Renderer>().material.color = Color.black;
                break;

            case "rojo":
                GetComponent<Renderer>().material.color = Color.red;
                break;

            case "azul":
                GetComponent<Renderer>().material.color = Color.blue;
                break;

            default:
                GetComponent<Renderer>().material.color = Color.white;
                break;
        }
    }
}
