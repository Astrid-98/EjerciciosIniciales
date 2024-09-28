using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    int velocidadJugador1 = 25;  
    int velocidadJugador2 = 10;
    int velocidadJugador3 = 75;

    // Start is called before the first frame update
    void Start()
    {
        if (velocidadJugador1 > velocidadJugador2 && velocidadJugador1 > velocidadJugador3) 
        {
            Debug.Log("Jugador 1 primero");
        } 
        else if (velocidadJugador2 > velocidadJugador1 && velocidadJugador2 > velocidadJugador3) 
        {
        Debug.Log("Jugador 2 primero");
        }
        else if (velocidadJugador3 > velocidadJugador1 && velocidadJugador3 > velocidadJugador2)
        {
            Debug.Log("Jugador 3 primero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
