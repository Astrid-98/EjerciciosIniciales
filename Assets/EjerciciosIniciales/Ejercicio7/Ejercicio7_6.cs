using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero;

    [SerializeField] int numero2;


    void Start()
    {
        int miNumero = numero;
        while (miNumero >= -numero)
        {
            Debug.Log(miNumero);
            miNumero--;
            
        }

        
        for (int miNumero2 = numero2; miNumero2 >= -numero2; miNumero2--)
        {
            Debug.Log(miNumero2);          
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
