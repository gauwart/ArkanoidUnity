using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionBloques : MonoBehaviour {

    public GameObject BloquePrfb;
    

    // Use this for initialization
    void Start () {
        CrearFilas(8);
	}
	

    void CrearFilas(int num)
    {
        for (float i = 0; i <= num; i++){
            CrearFila(3-(i/2));
        }
    }

    void CrearFila(float y)
    {
        for(int i = 1; i <=7; i++)
        {
            GameObject BloqueTemp = Instantiate(BloquePrfb, new Vector2(i-(7-i), y), Quaternion.identity);
        }
    }
}
