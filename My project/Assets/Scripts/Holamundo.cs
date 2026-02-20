using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hola mundo");
    }

    void Update()
    {
        Debug.LogWarning("Este es un advertencia");
    }

    void FixedUpdate()
    {
        Debug.LogError("Este es un error");
    }

    void Awake()
    {
        Debug.Log("Ya desperte(nose que poner)");
    }

      void LateUpdate()
    {
        Debug.LogError("Algo salió muy mal");

    }
}
