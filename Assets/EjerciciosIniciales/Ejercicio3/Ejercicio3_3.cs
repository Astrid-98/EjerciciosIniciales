using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    int numeroEntero = 7;

    int numeroDoble;
    int numeroTriple;

    // Start is called before the first frame update
    void Start()
    {
        numeroDoble = numeroEntero * 2;
        numeroTriple = numeroEntero * 3;
        Debug.Log(numeroDoble + " y " + numeroTriple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
