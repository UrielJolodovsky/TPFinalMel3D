using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyGun : MonoBehaviour
{
    int vendedor = 0;
    public static int armaUsar;
    // luego en el start de la escena Zombies ponemos que si armaUsar es un valor, solo se visibilice el arma correspondiente
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vendedor == 1 && Input.GetKeyDown(KeyCode.Q))
        {

        }
        else if (vendedor == 2 && Input.GetKeyDown(KeyCode.Q))
        {

        }
        else if (vendedor == 3 && Input.GetKeyDown(KeyCode.Q))
        {

        }
        else if (vendedor == 4 && Input.GetKeyDown(KeyCode.Q))
        {

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Vendedor1")
        {
            vendedor = 1;
        }
        if (other.gameObject.tag == "Vendedor2")
        {
            vendedor = 2;
        }
        if (other.gameObject.tag == "Vendedor3")
        {
            vendedor = 3;
        }
        if (other.gameObject.tag == "Vendedor4")
        {
            vendedor = 4;
        }
    }
    void OnTriggerExit(Collider other)
    {
        vendedor = 0;
    }
}
