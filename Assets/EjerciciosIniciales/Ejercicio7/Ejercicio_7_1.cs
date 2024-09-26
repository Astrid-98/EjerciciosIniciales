using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7_1 : MonoBehaviour
{
    int vidas = 1;
    // Start is called before the first frame update
    void Start()
    {
        while ( vidas < 100)
        {
            Debug.Log("Sigo vivo" + vidas);
            vidas++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
