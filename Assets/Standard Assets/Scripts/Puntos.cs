using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

    private int puntos = 0;
    public Text textoPuntos;
    private int record = 0;
    public Text textoRecord;
    public GameObject ganar;
    public ReiniciarJuego reiniciar;
    public Jugador jugador;
    public GameObject jugar;
    public GameObject salir;
    public GameObject nombre;
    public GameObject bola;
    public int verPuntos;
    

    // Use this for initialization
    void Start () {
        textoPuntos.text = "Puntos: " + puntos;
        textoRecord.text = reiniciar.puntosRecord + reiniciar.charNameRecord ;

    }

    // Update is called once per frame
    void Update () {

        verPuntos = puntos;

        if (puntos == 425)
        {
           Ganar();}


        }

    public void SumaPuntosVerde()
    {
        puntos = puntos + 10;
        textoPuntos.text = "Puntos: " + puntos;
    }

    public void SumaPuntosAzul()
    {
        puntos = puntos + 25;
        textoPuntos.text = "Puntos: " + puntos;
    }

    public void SumaPuntosMorado()
    {
        puntos = puntos + 50;
        textoPuntos.text = "Puntos: " + puntos;
    }

    public void Ganar()
    {
        
            ganar.SetActive(true);
            jugador.enabled = false;
            jugar.SetActive(true);
            salir.SetActive(true);
            nombre.SetActive(true);
            Destroy(bola);
            
        
    }

   

}
