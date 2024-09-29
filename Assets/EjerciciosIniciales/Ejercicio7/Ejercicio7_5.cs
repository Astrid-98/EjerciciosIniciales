using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;

    [SerializeField] int numero2;

    
    void Start()
    {
        int miNumero = 1;
        while (miNumero <= numero) //mientras miNumero 1 sea menor o igual a el numero que yo ponga en unity
        {
            Debug.Log(miNumero);  //imprime miNumero
            miNumero++;           //de uno en uno
        }

        //    desde  1,        1 hasta numero,       de uno en uno.
        for (int miNumero2 = 1; miNumero2 <= numero2; miNumero2++)
        {
            Debug.Log(miNumero2);  //imprime miNumero2           
        }
    }
}
