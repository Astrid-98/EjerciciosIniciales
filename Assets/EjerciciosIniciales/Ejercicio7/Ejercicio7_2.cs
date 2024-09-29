using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_2 : MonoBehaviour
{
    int numero;

    // Start is called before the first frame update
    void Start()
    {   //desde numero 1, hata 100, de uno en uno.
        for (int numero = 1; numero < 101; numero++) 
        {
            Debug.Log(numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
