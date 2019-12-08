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

    // Update is called once per frame
    void Update()
    {
        if (transform.position == new Vector3(-38.18667f, 5.343335f, 26.38f))
        { 
            Destroy(gameObject);
        }
    }
}
