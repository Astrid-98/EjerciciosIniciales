using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    float ladoCuadrado = 16f;
    float areaCuadrado;

    float radioCirculo = 9f;
    float pi = 3.14f;
    float areaCirculo;

    float baseTriangulo = 15f;
    float alturaTriangulo = 19.5f;
    float areaTriangulo;

    // Start is called before the first frame update
    void Start()
    {
        MetodoCuadrado();
        Debug.Log(areaCuadrado);
        
        MetodoCirculo();
        Debug.Log(areaCirculo);

        MetodoTriangulo();
        Debug.Log(areaTriangulo);
        
    }

    // Update is called once per frame
    void MetodoCirculo()
    {
        areaCirculo = (radioCirculo * radioCirculo) * pi;
    }

    void MetodoCuadrado()
    {
        areaCuadrado = ladoCuadrado * ladoCuadrado;
    }
    void MetodoTriangulo()
    {
        areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
    }
}
