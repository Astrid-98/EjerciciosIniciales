using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    int nivelPersonaje1 = 73;
    int nivelPersonaje2 = 50;

    // Start is called before the first frame update
    void Start()
    {
        if (nivelPersonaje1 % 2 == 0) 
        {
            Debug.Log("El nivel de personaje es par");
        }
        else
        {
            Debug.Log("El nivel del personaje es impar");
        }

        if (nivelPersonaje2 % 2 == 0)
        {
            Debug.Log("El nivel de personaje es par");
        }
        else
        {
            Debug.Log("El nivel del personaje es impar");
        }
    }
}
