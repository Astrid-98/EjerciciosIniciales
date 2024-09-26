using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    int numero1 = 5;
    int numero2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < 3)
        {
            Debug.Log("Verdadero");
        }
        else 
        {
            Debug.Log("Falso");
        }

        if (numero2 < 3) 
        {
            Debug.Log("Verdadero");
        }
        else
        {
            Debug.Log("Falso");
        }
    }
}
