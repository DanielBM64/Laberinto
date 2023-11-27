using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MovimientoPersonaje : MonoBehaviour
{
    public GameObject Personaje;
    public GameObject panelFinal;
    public Rigidbody2D rigidBodyTriangulo;
    public float movimientoHorizontal;
    public float movimientoVertical;
    public float velocidad;
    public float Tiempo = 0f;

    public Color color;
    public SpriteRenderer ColorSR;
    public bool Paralisis;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyTriangulo = GetComponent<Rigidbody2D>();
        velocidad = 4.5f;
        color = Color.cyan;
        ColorSR = GetComponent<SpriteRenderer>();
        Tiempo = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento de personaje
        movimientoHorizontal = Input.GetAxis("Horizontal");
        movimientoVertical = Input.GetAxis("Vertical");

        rigidBodyTriangulo.velocity = new Vector2(movimientoHorizontal, movimientoVertical) * velocidad;

        ColorSR.color = color;

        if (Paralisis == true)
        {
            velocidad = 0f;
            color = Color.red;
            Tiempo += Time.deltaTime;
            Tiempo.ToString();
        }
        
        if (Paralisis == false)
        {
            velocidad = 4.5f;
            color = Color.cyan;
            Tiempo = 0;
        }
        if (Tiempo > 2)
        {
            Paralisis = false;
        }
    }   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Coger Moneda
        if (collision.gameObject.CompareTag("Moneda"))
        {
            Destroy(collision.gameObject);

        }
        else if (collision.gameObject.CompareTag("Fin"))
        {
            Destroy(collision.gameObject);
            panelFinal.SetActive(true);
            Time.timeScale = 0f;
        } 

        //Choque Obstaculo

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Debug.Log("¡Cuidado Rey!");
            Paralisis = true;
        }
    }
}
