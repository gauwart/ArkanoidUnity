using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour {

    public Vidas vidas;
    public Vector2 posInicial;
    public Bola bola;
    public Jugador jugador;



    // Use this for initialization
    void Update()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bola")
        {
            jugador.Reset();
            bola.Reset();
            
            vidas.PerderVida();

        }
    }


}
