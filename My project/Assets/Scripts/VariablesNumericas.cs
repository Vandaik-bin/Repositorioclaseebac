using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];
        int[] arr3 = new int[5];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Random.Range(0, 10);
            arr2[i] = Random.Range(0, 10);

            arr3[i] = arr1[i] + arr2[i];

            Debug.Log("arr1[" + i + "] = " + arr1[i] +
                      " | arr2[" + i + "] = " + arr2[i] +
                      " | arr3[" + i + "] = " + arr3[i]);
        }

        string[] palabras = { "Hola", "soy", "Emiliano" };

        string oracion = "";

        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }

        Debug.Log("Oración: " + oracion);

        int[,] matriz = new int[2, 2]
        {
            {1, 2},
            {3, 4}
        };

        int[] vector = new int[2] { 5, 6 };

        int[] resultado = new int[2];

        for (int i = 0; i < 2; i++) 
        {
            resultado[i] = 0;

            for (int j = 0; j < 2; j++) 
            {
                resultado[i] += matriz[i, j] * vector[j];
            }

            Debug.Log("Resultado[" + i + "] = " + resultado[i]);
        }
    }

}
