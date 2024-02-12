
using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movimientos Básicos
    public float velocidadMovimiento = 5f;
    public float velocidadRotacion = 100f;

    public float x, y;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Lectura cursores
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        //Movimiento
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);


    }

}

