using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int vidas = 100;

    // Start is called before the first frame update
    void Start()
    {
        while (vidas > 0)
        {
            Debug.Log(vidas);
            vidas--;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
