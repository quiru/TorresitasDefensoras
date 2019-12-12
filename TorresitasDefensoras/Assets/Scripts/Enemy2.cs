using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    int sangre = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<bala>())
        {
            sangre -= 1;
            if (sangre <= 0)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
