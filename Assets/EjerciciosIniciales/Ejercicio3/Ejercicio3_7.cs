using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    float baseTriangulo = 14f;
    float alturaTriangulo = 17.5f;

    float area;

    // Start is called before the first frame update
    void Start()
    {
        area = (baseTriangulo * alturaTriangulo) / 2;
        Debug.Log(area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
