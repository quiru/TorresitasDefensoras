using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    public GameObject cannon0;
    public GameObject cannon1;
    public GameObject cannon2;
    public static GameObject creador;
    public static bool selecActual;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Boton1()
    {
        if (ColocadorTorres.contadorTorres < 3 && selecActual == false)
        {
            creador = cannon0;
            selecActual = true;
        }
    }
    public void Boton2()
    {
        if (ColocadorTorres.contadorTorres < 3 && selecActual == false)
        {
            creador = cannon1;
            selecActual = true;
        }
    }
    public void Boton3()
    {
        if (ColocadorTorres.contadorTorres < 3 && selecActual == false)
        {
            creador = cannon2;
            selecActual = true;
        }
    }
}
