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

    
}
