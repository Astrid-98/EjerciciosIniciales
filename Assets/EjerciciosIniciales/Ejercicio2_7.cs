using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oroPorSegundo = 7;
    int segundosPorHora = 3600;
    int horas = 4;
    int unidadesOroFarmeadas;

    // Start is called before the first frame update
    void Start()
    {   
        unidadesOroFarmeadas = oroPorSegundo * (segundosPorHora * horas);
        Debug.Log(unidadesOroFarmeadas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
