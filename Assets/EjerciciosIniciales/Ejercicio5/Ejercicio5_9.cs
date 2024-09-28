using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int enemigoTipo;
  
    // Start is called before the first frame update
    void Start()
    {
        if( enemigoTipo == 1)
        {
            int danho = 350;
            int vida = 650;
            Debug.Log("Daño " + danho + " y vida " + vida);
        }
        else if( enemigoTipo == 2) 
        {
            int danho = 300;
            int vida = 550;
            Debug.Log("Daño " + danho + " y vida " + vida);
        }
        else if (enemigoTipo == 3)
        {
            int danho = 300;
            int vida = 500;
            Debug.Log("Daño " + danho + " y vida " + vida);
        }
        else if (enemigoTipo == 4)
        {
            int danho = 310;
            int vida = 460;
            Debug.Log("Daño " + danho + " y vida " + vida);
        }
        else if (enemigoTipo == 5)
        {
            int danho = 280;
            int vida = 490;
            Debug.Log("Daño " + danho + " y vida " + vida);
        }
        else if (enemigoTipo == 6)
        {
            int danho = 360;
            int vida = 520;
            Debug.Log("Daño " + danho + " y vida " + vida);
        }
    }
}
