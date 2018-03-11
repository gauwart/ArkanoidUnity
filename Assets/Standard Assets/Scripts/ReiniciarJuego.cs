using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReiniciarJuego : MonoBehaviour {

    public InputField nameField;
    public string charName;
    public Text textoRecord;
    public Puntos puntos;
    public Vidas vidas;
    public int puntosFinal;
    public int puntosRecord;
    public string charNameRecord;

  

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    public void OnSubmit()
    {
        if (puntos.verPuntos > puntosFinal)
        {
            puntosFinal = puntos.verPuntos;
        

        charName = nameField.text;
        Debug.Log("Has introducido" + charName +" "+ puntosFinal);
            puntosRecord = puntosFinal;
            charNameRecord = charName;
        }



    }

    public void Reiniciar()
    {
        
        SceneManager.LoadScene("Nivel01");
        vidas.ReiniciarVidas();
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo");
    }

    


}

