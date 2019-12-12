using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creador3 : MonoBehaviour
{
    public Transform enemigo;
    Transform instanciador;
    public Transform salida;
    float tiempoSalida = 7;
    float contador = 3;
    int numEnemigos = 0;

    void Update()
    {
        if (Llegada.juego)
        {
            int contTmp = (int)Time.timeSinceLevelLoad;
            if (contTmp >= 180)
            {
                if (contador <= 0)
                {
                    StartCoroutine("CreaIntervalo");
                    contador = tiempoSalida;
                }

                contador -= Time.deltaTime;
            }
        }
    }

    IEnumerator CreaIntervalo()
    {
        numEnemigos = Random.Range(1, 7);
        tiempoSalida += 1f;
        for (int i = 0; i < numEnemigos; i++)
        {
            instanciador = Instantiate(enemigo, new Vector3(salida.position.x, salida.position.y, salida.position.z), salida.rotation);
            instanciador.name = "enemy";
            yield return new WaitForSeconds(4f);
        }
    }
}
