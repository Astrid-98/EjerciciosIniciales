using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    float puntuacion1 = 5;
    float puntuacion2 = 3;
    int puntuacion3 = 20;

    float mediaPuntuacion1;
    float mediaPuntuacion2;
    float mediaPuntuacion3;

    // Start is called before the first frame update
    void Start()
    {
        //4 , 9, 7 --> Los sumas y los divides entre 
        mediaPuntuacion1 = puntuacion1 / 2;
        Debug.Log("Puntuacion1 = " + puntuacion1 + " Media = " + mediaPuntuacion1);

        mediaPuntuacion2 = puntuacion2 / 2;
        Debug.Log("Puntuacion2 = " + puntuacion2 + " Media = " + mediaPuntuacion2);

        mediaPuntuacion3 = puntuacion3 / 2;
        Debug.Log("Puntuacion3 = " + puntuacion3 + " Media = " + mediaPuntuacion3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
