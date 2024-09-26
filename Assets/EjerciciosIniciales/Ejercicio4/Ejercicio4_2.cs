using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string nombre = "Leslie";
    string apellido1 = "Portilla";
    string apellido2 = "Martinez";
    int edad = 26;
    // Start is called before the first frame update
    void Start()
    {
        ConstruirNombre();
    }
    void ConstruirNombre()
    {
        Debug.Log("La persona se llama " + nombre + " " + apellido1 + " "  + apellido2 + " " + "y tiene " + edad + " años");
    }
}
