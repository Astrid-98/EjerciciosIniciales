using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int numero;

    // Start is called before the first frame update
    void Start()
    {
        for (int numero1 = 1; numero1 <= numero; numero1++) 
        {
            if (numero1 % 3 ==0)
            {
                Debug.Log(numero1);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
