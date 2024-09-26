using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 9;
    float exp = 3.5f;

    float resultadoMultiplicacion;
    float resultadoDivision;
    float resultadoResto;
    float dobleDeVidas;
    float triple;

    // Start is called before the first frame update
    void Start()
    {
        float resultadoMultiplicacion = vidas * exp;
        Debug.Log(resultadoMultiplicacion);

        float resultadoDivision = vidas/exp;
        Debug.Log(resultadoDivision);

        float resultadoResto = vidas % exp;
        Debug.Log(resultadoResto);

        float dobleDeVidas = vidas * 2;
        Debug.Log(dobleDeVidas);

        float triple = exp * 3;
        Debug.Log(triple);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
