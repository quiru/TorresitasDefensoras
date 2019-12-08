using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * 2.2f;
        Destroy(gameObject, 2);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<DestinoNavMesh>())
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
