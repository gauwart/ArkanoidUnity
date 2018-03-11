using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour {

    public int vida;
    private int numChoques = 0;
    public Puntos puntos;

    // Use this for initialization
    void Start () {
        
        
    }
	
	

    private void OnCollisionEnter2D(Collision2D collision)
    {
        numChoques++;

    }

    void Update()
    {
        if (numChoques == vida)
        {
            Destroy(gameObject);
            if(vida == 1) { puntos.SumaPuntosVerde(); }
            else if(vida == 2) { puntos.SumaPuntosAzul(); }
            else if(vida == 3) { puntos.SumaPuntosMorado(); }
            
        }
    }

}
