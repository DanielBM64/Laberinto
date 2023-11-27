using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ContadorMonedaC : MonoBehaviour
{
    public TMP_Text ContadorMonedas;
    public float Monedas = 0f;
    public TMP_Text frase;
    public GameObject Personaje;
    // Start is called before the first frame update
    void Start()
    {
        ContadorMonedas.text = "0";
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        
        if (collision.gameObject.CompareTag("Moneda"))
        {
            Debug.Log("+1");
            Monedas++;
            ContadorMonedas.text = Monedas.ToString();
        }
        if (Monedas == 1)
        {
            frase.text = "Conseguiste 1 moneda, ahora puedes comprar pan, felicidades";
        }
        else if (Monedas == 2)
        {
            frase.text = "Bueno, conseguiste 2 monedas, ahora puedes comprar  dos panes. Poquito a poco";
        }
        else if (Monedas == 3)
        {
            frase.text = "Bien, has conseguido la mitad de monedas, ni tan mal";
        }
        else if (Monedas == 4)
        {
            frase.text = "Vamos, vamos, aún puedes conseguir más monedas";
        }
        else if (Monedas == 5)
        {
            frase.text = "Uyy, a una de tenerlas todas ¡¡Tú puedess!!";
        }
        else if (Monedas == 6)
        {
            frase.text = "Boooff, qué grande ¡¡Has conseguido todas las monedas!!";
        }
    }
}