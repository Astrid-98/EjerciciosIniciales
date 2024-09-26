using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    float radioCircunferencia = 83f;
    float pi = 3.14159265358979f;

    float longitudCircunferencia;
    float areaCircunferencia;


    // Start is called before the first frame update
    void Start()
    {
        longitudCircunferencia = 2 * pi * radioCircunferencia;
        areaCircunferencia = (pi * radioCircunferencia) * (pi * radioCircunferencia);
        Debug.Log(longitudCircunferencia);
        Debug.Log(areaCircunferencia);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
