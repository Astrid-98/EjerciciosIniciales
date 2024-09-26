using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 5;

    int incrementarVidas;
    int decrementarVidas;
    int cuadriplicarVidas;

    // Start is called before the first frame update
    void Start()
    {
        int incrementarVidas = vidas * 77; //No entiendo si es hasta llegar a 77 o 77 veces su valor? 
        Debug.Log(incrementarVidas);

        int decrementarVidas = vidas++;
        Debug.Log(decrementarVidas);

        int cuadriplicarVidas = vidas * 4;
        Debug.Log(cuadriplicarVidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
