using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBola : MonoBehaviour {

    private AudioSource sonido;
    public AudioClip SonidoBloque;
    public AudioClip rebote;

	// Use this for initialization
	void Start () {
        sonido = GetComponent<AudioSource>();
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pared")
        {
            sonido.clip = rebote;
            sonido.Play();
            
        }else if (collision.gameObject.tag == "Player")
        {
            sonido.clip = rebote;
            sonido.Play();
        }
        else if (collision.gameObject.tag == "Bloque")
        {
            sonido.clip = SonidoBloque;
            sonido.Play();
        }
    }
}
