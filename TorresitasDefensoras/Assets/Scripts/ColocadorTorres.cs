using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocadorTorres : MonoBehaviour
{
    public GameObject torret;
    public static int contadorTorres = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (contadorTorres < 3 && Tienda.creador != null)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit obj;
                if (Physics.Raycast(ray, out obj, Mathf.Infinity))
                {
                    Instantiate(Tienda.creador, new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z), Quaternion.Euler(0, obj.transform.rotation.y, obj.transform.rotation.z));
                    contadorTorres += 1;
                    Tienda.selecActual = false;
                }
            }
        }
        print(contadorTorres);
    }
}
