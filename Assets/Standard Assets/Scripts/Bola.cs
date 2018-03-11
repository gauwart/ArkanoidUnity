using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola : MonoBehaviour {

    public Text textSpace;
    private Rigidbody2D rb;
    Vector3 posicionInicial;
    public bool enJuego = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        posicionInicial = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        // if (Input.GetKey(KeyCode.Space) && enJuego == false)
        //{
        //  EmpiezaJuego();
        //enJuego = true;
        //}

        if (Input.GetMouseButtonDown(0) && enJuego == false)
        {
            EmpiezaJuego();
            enJuego = true;
        }
            
        
    }

    public void Reset(){

        transform.position = posicionInicial;
        rb.velocity = Vector2.zero;
        enJuego = false;
    }

    public void EmpiezaJuego()
    {
        rb.isKinematic = false;
        rb.velocity = new Vector2(3f, 3f);
        textSpace.text = "";
    }



}
