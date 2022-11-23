using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarFotos : MonoBehaviour
{
    [SerializeField] GameObject Vendedor1Foto;
    [SerializeField] GameObject Vendedor2Foto;
    [SerializeField] GameObject Vendedor3Foto;
    [SerializeField] GameObject Vendedor4Foto;
    // Start is called before the first frame update
    void Start()
    {
        Vendedor1Foto = GameObject.FindGameObjectWithTag("Vendedor1Foto");
        Vendedor2Foto = GameObject.FindGameObjectWithTag("Vendedor2Foto");
        Vendedor3Foto = GameObject.FindGameObjectWithTag("Vendedor3Foto");
        Vendedor4Foto = GameObject.FindGameObjectWithTag("Vendedor4Foto");
        Vendedor1Foto.SetActive(false);
        Vendedor2Foto.SetActive(false);
        Vendedor3Foto.SetActive(false);
        Vendedor4Foto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
