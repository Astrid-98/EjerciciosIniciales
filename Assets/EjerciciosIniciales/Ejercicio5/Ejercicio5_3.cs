using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    int edad = 4;

    // Start is called before the first frame update
    void Start()
    {
        if (edad >= 0 && edad <= 9)
        {
            Debug.Log( edad );
        } 
        else 
        {
            Debug.Log("error");
        }
    }

    
}
