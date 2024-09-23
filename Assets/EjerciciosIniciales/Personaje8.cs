using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje8 : MonoBehaviour
{
    private string nombre;
    private int vida;
    private int experiecia;
    private float calcularNivel;
    // Start is called before the first frame update
    float  CalcularNivel()
    {
        calcularNivel = experiecia / 100;
        return calcularNivel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
