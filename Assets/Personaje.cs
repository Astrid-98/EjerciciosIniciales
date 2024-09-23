using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    //COMO se define un personaje
    //Propiedades o atributos
    private string nombre; // ""
    private float vida; //0
    private float danho; //0
    private float velocidad; // 0

    public float Vida { get => vida; set => vida = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float Danho { get => danho; set => danho = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }

    // QUE  puede hacer mi personaje
    //Funcionalidades
    void Mover(float x, float y, float z)
    {

    }
    void Atacar () 
    { 

    }
    void Saltar()
    { 

    }
}
