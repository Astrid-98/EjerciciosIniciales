using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;

    // Start is called before the first frame update
    void Start()
    {
        int miNumero = 1;
        while (miNumero <= numero) //mientras miNumero 1 sea menor o igual a el numero que yo ponga en unity
        {
            Debug.Log(miNumero);  //imprime miNumero
            miNumero++;           //de uno en uno
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
