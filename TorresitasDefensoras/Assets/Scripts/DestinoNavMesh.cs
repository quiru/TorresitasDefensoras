using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestinoNavMesh : MonoBehaviour
{
    public NavMeshAgent enemy0;

    void Start()
    {
        enemy0.destination = GameObject.Find("Floor01 (133)").transform.position;
    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Llegada")
        {
            Creador.contEnemigos += 1;
            Destroy(gameObject);
        }
    }
}
