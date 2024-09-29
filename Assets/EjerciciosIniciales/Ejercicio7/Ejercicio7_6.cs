using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero;

    // Start is called before the first frame update
    void Start()
    {
        
        //    desde  1,        1 hasta numero,    de uno en uno.
        for (int miNumero = 1; miNumero <= numero; miNumero++)
        {
            Debug.Log(miNumero);  //imprime miNumero            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
