using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int temperatura;

    // Start is called before the first frame update
    void Start()
    {
        // >= <=
        if (temperatura <= 10)
        {
            Debug.Log("Tipo de clima frío");
        }
        else if ( temperatura > 10 && temperatura <= 20)
        {
            Debug.Log("Tipo de clima nublado");
        }
        else if (temperatura > 20 && temperatura <= 30)
        {
            Debug.Log("Tipo de clima caluroso");
        }
        else if (temperatura > 30)
        {
            Debug.Log("Tipo de clima tropical");
        }
    }
}
