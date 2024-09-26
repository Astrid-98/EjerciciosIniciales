using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    int puntosExperiencia = 105;
    int nivel; //LVL

    // Start is called before the first frame update
    void Start()
    {
        nivel = 32 + (9 * puntosExperiencia / 5);
        Debug.Log(nivel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
