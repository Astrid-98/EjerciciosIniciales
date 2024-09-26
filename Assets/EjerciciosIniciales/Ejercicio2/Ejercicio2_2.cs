using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 7;
    float exp = 5.6f;
    char carac = 'c';

    float resultadoSuma;
    float resultadoResta;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas);
        Debug.Log(exp);

        float resultadoSuma = vidas + exp;
        Debug.Log(resultadoSuma);

        float resultadoResta = exp - vidas;
        Debug.Log (resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
