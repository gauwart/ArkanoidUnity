using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vidas : MonoBehaviour {

    public static int vidas = 3;
    public Text textoVidas;
    public GameObject gameOver;
    public Jugador jugador;
    public ReiniciarJuego reiniciar;
    public GameObject jugar;
    public GameObject salir;
    public GameObject nombre;
    public Bola bola;


	// Use this for initialization
	void Start () {
        ActualizarMacardorVidas();
	}
	
	// Update is called once per frame
	void ActualizarMacardorVidas() {
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }

    public void PerderVida()
    {
        if (vidas <= 0) return;

        Vidas.vidas--;
        ActualizarMacardorVidas();

        if (vidas <= 0)
        {
            gameOver.SetActive(true);
            jugador.enabled = false;
            jugar.SetActive(true);
            salir.SetActive(true);
            nombre.SetActive(true);
            bola.enabled = false;
        }
    }

    public void ReiniciarVidas()
    {
        Vidas.vidas = 3;
    }
}
