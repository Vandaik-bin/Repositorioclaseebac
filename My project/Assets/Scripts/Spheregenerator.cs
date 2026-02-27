using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheregenerator : MonoBehaviour
{
    public GameObject PrefabSphere;
    public List<GameObject> listaDeesferas;
    public float Escalamiento;
    public int numSpheras=0;

    void Awake()
    {
        GameObject obj = Instantiate(PrefabSphere);

        MeshRenderer renderer = obj.GetComponent<MeshRenderer>();
        renderer.material = new Material(renderer.material);
        renderer.material.color = Random.ColorHSV();
    }
    
    void OnEnable()
    {
        Instantiate(PrefabSphere);
    }

   
    void OnDisable()
    {
        if (Application.isPlaying)
        {
            Instantiate(PrefabSphere);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        listaDeesferas = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numSpheras++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabSphere);
        tempGameObject.name = "Spherasnum" + numSpheras;
        Color c = new Color(Random.value, Random.value, Random.value, 1f);
        MeshRenderer renderer = tempGameObject.GetComponent<MeshRenderer>();
        renderer.material = new Material(renderer.material);
        renderer.material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        
        listaDeesferas.Add(tempGameObject);
        List<GameObject> objetosaeliminar = new List<GameObject>();
        foreach (GameObject go in listaDeesferas)
        {
         
            float scale = go.transform.localScale.x;
            scale *= Escalamiento;
            go.transform.localScale = Vector3.one * scale;
            if(scale <= 0.1)
            {
                objetosaeliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosaeliminar)
        {
            listaDeesferas.Remove(go);
            Destroy(go);
        }
    }

    
    void FixedUpdate()
    {
        foreach (GameObject go in listaDeesferas)
        {
            MeshRenderer renderer = go.GetComponent<MeshRenderer>();
            renderer.material.color = Random.ColorHSV();
        }
    }
}
