using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy0 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<bala>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);        }
    }
}
