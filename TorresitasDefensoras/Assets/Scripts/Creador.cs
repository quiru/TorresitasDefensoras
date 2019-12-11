using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creador : MonoBehaviour
{
    public Transform enemigo;
    Transform instanciador;
    public Transform salida;
    float tiempoSalida = 6;
    float contador = 2;
    int numEnemigos = 0;
    public static int contEnemigos = 0;
    
    void Update()
    {
        if (contEnemigos < 5)
        {
            if (contador <= 0)
            {
                StartCoroutine("CreaIntervalo");
                contador = tiempoSalida;
            }

            contador -= Time.deltaTime;
        }
        else if (contEnemigos >= 5)
        {

        }
    }

    IEnumerator CreaIntervalo()
    {
        numEnemigos++;
        tiempoSalida += 0.3f;
        for (int i = 0; i < numEnemigos; i++)
        {
            instanciador = Instantiate(enemigo, salida.position, salida.rotation);
            instanciador.name = "enemy";
            yield return new WaitForSeconds(1f);
        }
    }
}
