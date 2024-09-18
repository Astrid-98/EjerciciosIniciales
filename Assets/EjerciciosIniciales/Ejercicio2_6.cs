using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    float puntuacion1 = 5;
    float puntuacion2 = 3;
    float puntuacion3 = 20;

    float mediaPuntuacion;


    // Start is called before the first frame update
    void Start()
    {
        mediaPuntuacion = (puntuacion1 + puntuacion2 + puntuacion3)/ 3;
        Debug.Log(mediaPuntuacion);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
