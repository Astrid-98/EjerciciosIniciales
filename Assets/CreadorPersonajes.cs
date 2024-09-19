using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    int numero = 5;
    string testo = "Hola";
    float num = 3.4f;
    [SerializeField] Personaje personaje;
    //[SerializeField]Personaje troll = null; //Esta llamando al script. Tiene tipo, nombre y valor, su valor por defecto es null.
    //Para encadenar valor del unity al script tiene que estar serializado.




    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
