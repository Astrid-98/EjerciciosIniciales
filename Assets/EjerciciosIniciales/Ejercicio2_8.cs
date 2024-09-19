using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vidaInicial = 120f;
    
    float turno1;
    float turno2;
    float turno3;
    float turno4;
    float turno5;



    
    void Start()
    {
        turno1 = 3 * vidaInicial / 100;
        Debug.Log(turno1);

        turno2 = 6 * vidaInicial / 100;
        Debug.Log(turno2);

        turno3 = 9 * vidaInicial / 100;
        Debug.Log(turno3);

        turno4 = 12 * vidaInicial / 100;
        Debug.Log(turno4);

        turno5 = 15 * vidaInicial / 100;
        Debug.Log(turno5);
           
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
