using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

    private Rigidbody2D rb;

    Vector3 posicionInicial;

    public ElementoInteractivo derecha;
    public ElementoInteractivo izquierda;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        posicionInicial = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        MoverBarra();
    }

    public void MoverBarra()
    {
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //rb.velocity = new Vector2(-5f, 0);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //rb.velocity = new Vector2(5f, 0);
        //}
        //else
        //{
        //rb.velocity = new Vector2(0f, 0);
        //}


        if (izquierda.pulsado)
        {
            rb.velocity = new Vector2(-5f, 0);
        }
        else if (derecha.pulsado)
        {
            rb.velocity = new Vector2(5f, 0);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0);
        }
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }
}
