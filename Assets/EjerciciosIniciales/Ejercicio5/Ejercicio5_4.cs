using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    int numero1 = 20;
    int numero2 = 4;
    int division;

    // Start is called before the first frame update
    void Start()
    {
        if (numero2 != 0) 
        {
            division = (numero1 / numero2);

            Debug.Log(division);
        }
    }
    
}
