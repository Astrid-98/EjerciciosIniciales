using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 4;
    int vidasPlayer2 = 7;
    int vidasPlayer3 = 2;
    int vidasPlayer4 = 8;

    // Start is called before the first frame update
    void Start()
    {
       vidasPlayer2 = vidasPlayer3;
       Debug.Log(vidasPlayer2);

       vidasPlayer3 = vidasPlayer1;
       Debug.Log(vidasPlayer3);

       vidasPlayer1 = vidasPlayer4;
       Debug.Log(vidasPlayer1);

        vidasPlayer4 = vidasPlayer2;
        Debug.Log(vidasPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
