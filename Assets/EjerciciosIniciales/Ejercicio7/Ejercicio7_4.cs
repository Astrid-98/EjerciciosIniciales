using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_4 : MonoBehaviour
{
    int numero;

    // Start is called before the first frame update
    void Start()
    {   //desde numero 100, hata 1, de uno en uno.
        for (int numero = 100; numero > 1; numero--)
        {
            Debug.Log(numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
