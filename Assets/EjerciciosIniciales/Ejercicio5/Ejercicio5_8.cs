using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
   [SerializeField] int horas; // de 0 a 23
   [SerializeField] int minutos; // de 0 a 59
   [SerializeField] int segundos; // de 0 a 59

    int miHora;

    // >= <=
    // Start is called before the first frame update
    void Start()
    {
       if(horas >= 0 && horas <= 23 || minutos >= 0 && minutos <= 59 || segundos >= 0 && segundos <= 59)
       {
            Debug.Log(horas + " : " + minutos + " : " + segundos);
       }
       else
       {
            Debug.Log("Error");
       }
    }
}
