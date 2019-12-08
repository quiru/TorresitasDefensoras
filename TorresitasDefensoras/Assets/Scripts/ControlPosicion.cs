using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPosicion : MonoBehaviour
{
    public Material colorCambio;
    Material colActual;
    bool hayTorreta;

    void Start()
    {
        colActual = gameObject.GetComponent<Renderer>().material;
        InvokeRepeating("CambiaCol", 2, 1);
    }

    IEnumerator CambiaColor()
    {
        yield return new WaitForSeconds(2);
        GetComponent<Renderer>().material = colorCambio;
        yield return new WaitForSeconds(2);
        GetComponent<Renderer>().material = colActual;
        yield return new WaitForSeconds(2);
    }

    IEnumerator ConTorreta()
    {
        yield return new WaitForSeconds(0.2f);
        GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(60);
        GetComponent<BoxCollider>().enabled = true;
        hayTorreta = false;
    }

    private void OnMouseDown()
    {
        hayTorreta = true;
    }

    bool camb;
    void CambiaCol()
    {
        camb = !camb;
    }

    void Update()
    {
        if (!hayTorreta)
        {
            if (camb)
            {
                GetComponent<Renderer>().material = colorCambio;
            }
            else
            {
                GetComponent<Renderer>().material = colActual;
            }
        }
        else
        {
            StartCoroutine("ConTorreta");
        }
    }
}
