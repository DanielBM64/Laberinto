using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Contador : MonoBehaviour
{
    public TMP_Text TextoContador;
    public float Tiempo = 0f;
    public GameObject Panel;
    public GameObject Personaje;
    // Start is called before the first frame update
    void Start()
    {
        TextoContador.text = "30";
        Tiempo = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo -= Time.deltaTime;
        TextoContador.text = Tiempo.ToString("f1");
        if (Tiempo < 0)
        {
            Panel.SetActive(true);
            Destroy(Personaje.gameObject);
            Time.timeScale = 0f;
        }

    }
}
