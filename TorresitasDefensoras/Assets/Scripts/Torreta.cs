using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
    public Transform objetivo;
    float rango = 15;
    public Transform partRota;

    public GameObject bala;
    public Transform disparador;
    float velDisparo = 1;
    float contFuego = 0;
    public ParticleSystem humo;


    void Start()
    {
        InvokeRepeating("ActualiObj", 0, 0.5f);
        Invoke("Destruir", 60);
    }

    void ActualiObj()
    {
        GameObject[] enemis = GameObject.FindGameObjectsWithTag("Enemys");
        float distCercana = Mathf.Infinity;
        GameObject enemCercano = null;

        foreach (GameObject enem in enemis)
        {
            float distAEnemi = Vector3.Distance(transform.position, enem.transform.position);
            if (distAEnemi < distCercana)
            {
                distCercana = distAEnemi;
                enemCercano = enem;
            }
        }
        if (enemCercano != null && distCercana <= rango)
        {
            objetivo = enemCercano.transform;
        }
        else
        {
            objetivo = null;
        }
    }
    
    void Update()
    {

        if (objetivo == null)
        {
            return;
        }

        partRota.transform.LookAt(objetivo);

        if (contFuego <= 0)
        {
            Instantiate(bala, disparador.position, disparador.rotation);
            contFuego = 1 / velDisparo;
            humo.Play();
        }
        contFuego -= Time.deltaTime;

        
    }

    void Destruir()
    {
        ColocadorTorres.contadorTorres -= 1;
        Destroy(gameObject);
    }
}
