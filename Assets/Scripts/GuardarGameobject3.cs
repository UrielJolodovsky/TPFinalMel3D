using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarGameobject3 : MonoBehaviour
{
    public static GuardarGameobject3 posicion;
    void Awake()
    {
        if (GuardarGameobject3.posicion == null)
        {
            GuardarGameobject3.posicion = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

