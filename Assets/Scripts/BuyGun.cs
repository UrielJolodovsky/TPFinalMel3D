using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class BuyGun : MonoBehaviour
{
    int vendedor = 0;
    [SerializeField] public static int armaUsar = 0;
    [SerializeField] Text ArmaActual;
    [SerializeField] Text comprarArma;
    [SerializeField] Text Dinero;
    [SerializeField] Money MN;
    [SerializeField] GameObject Vendedor1;
    [SerializeField] GameObject Vendedor2;
    [SerializeField] GameObject Vendedor3;
    [SerializeField] GameObject Vendedor4;
    [SerializeField] GameObject Vendedor1Foto;
    [SerializeField] GameObject Vendedor2Foto;
    [SerializeField] GameObject Vendedor3Foto;
    [SerializeField] GameObject Vendedor4Foto;
    [SerializeField] bool comprable;
    [SerializeField] GameObject Arma0;
    [SerializeField] public static Vector3 spawn;
    // luego en el start de la escena Zombies ponemos que si armaUsar es un valor, solo se visibilice el arma correspondiente
    // Start is called before the first frame update
    void Start()
    {
        spawn = gameObject.transform.position;
        if (SceneManager.GetActiveScene().name == "Shop")
        {
            gameObject.transform.position = new Vector3(spawn.x, spawn.y , spawn.z);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Shop")
        {
            //gameObject.transform.position = new Vector3(spawn.x, spawn.y , spawn.z);
            comprarArma = GameObject.FindGameObjectWithTag("ComprarArma").GetComponent<Text>();
            Dinero = GameObject.FindGameObjectWithTag("Dinero").GetComponent<Text>();
            ArmaActual = GameObject.FindGameObjectWithTag("ArmaActual").GetComponent<Text>();
            Vendedor1 = GameObject.FindGameObjectWithTag("Vendedor1");
            Vendedor2 = GameObject.FindGameObjectWithTag("Vendedor2");
            Vendedor3 = GameObject.FindGameObjectWithTag("Vendedor3");
            Vendedor4 = GameObject.FindGameObjectWithTag("Vendedor4");
            Vendedor1Foto = GameObject.FindGameObjectWithTag("Vendedor1Foto");
            Vendedor2Foto = GameObject.FindGameObjectWithTag("Vendedor2Foto");
            Vendedor3Foto = GameObject.FindGameObjectWithTag("Vendedor3Foto");
            Vendedor4Foto = GameObject.FindGameObjectWithTag("Vendedor4Foto");
            Arma0 = GameObject.FindGameObjectWithTag("Arma0");
            /*Vendedor1Foto.SetActive(false);
            Vendedor2Foto.SetActive(false);
            Vendedor3Foto.SetActive(false);
            Vendedor4Foto.SetActive(false);*/
        }
        Dinero.text = "Dinero actual: " + MN.money.ToString() + " $";
        ArmaActual.text = "El nivel de tu arma actual es: " + armaUsar.ToString();
        if (vendedor == 1)
        {
            if (MN.money >= 10)
            {
                comprarArma.text = "Presiona Q para comprar el arma" + "\n" + "Precio: 10 $";
                if (armaUsar <= 1)
                {
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        armaUsar = 1;
                        MN.money -= 10;
                        Vendedor1.SetActive(false);
                        comprarArma.enabled = false;
                        Vendedor1Foto.SetActive(true);
                        Arma0.SetActive(false);
                    }
                }
                else
                {
                    comprarArma.text = "Tienes un arma mejor que esta. Porque comprarla?";
                }
            }
            else 
                comprarArma.text = "No tienes suficiente dinero";
        }
        else if (vendedor == 2)
        {
            if (MN.money >= 30)
            {
                comprarArma.text = "Presiona Q para comprar el arma" + "\n" + "Precio: 30 $";
                comprable = true;
                if (armaUsar <= 2)
                {
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                    armaUsar = 2;
                    MN.money -= 30;
                    Vendedor2.SetActive(false);
                    comprarArma.enabled = false;
                    Vendedor2Foto.SetActive(true);
                    Vendedor1Foto.SetActive(false);
                    Arma0.SetActive(false);
                    }
                }
                else
                {
                    comprarArma.text = "Tienes un arma mejor que esta. Porque comprarla?";
                }
            }
            else
                comprarArma.text = "No tienes suficiente dinero";
        }
        else if (vendedor == 3)
        {
            if (MN.money >= 50)
            {
                comprarArma.text = "Presiona Q para comprar el arma" + "\n" + "Precio: 50 $";

                if (armaUsar <= 3)
                {
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        armaUsar = 3;
                        MN.money -= 50;
                        comprarArma.text = "Arma comprada";
                        Vendedor3.SetActive(false);
                        comprarArma.enabled = false;
                        Vendedor3Foto.SetActive(true);
                        Vendedor2Foto.SetActive(false);
                        Vendedor1Foto.SetActive(false);
                        Arma0.SetActive(false);
                    }
                }
                else
                {
                   comprarArma.text = "Tienes un arma mejor que esta. Porque comprarla?";
                }
            }      
            else
                comprarArma.text = "No tienes suficiente dinero";
        }
        else if (vendedor == 4)
        {
            if (MN.money >= 70)
            {
                comprarArma.text = "Presiona Q para comprar el arma" + "\n" + "Precio: 70 $";
                if (Input.GetKeyDown(KeyCode.Q) && armaUsar <= 4)
                {
                    armaUsar = 4;
                    MN.money -= 70;
                    Vendedor4.SetActive(false);
                    comprarArma.enabled = false;
                    Vendedor4Foto.SetActive(true);
                    Vendedor3Foto.SetActive(false);
                    Vendedor2Foto.SetActive(false);
                    Vendedor1Foto.SetActive(false);
                    Arma0.SetActive(false);
                }
            }
            else
                comprarArma.text = "No tienes suficiente dinero";
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Vendedor1")
        {
            vendedor = 1;
            comprarArma.enabled = true;
        }
        if (other.gameObject.tag == "Vendedor2")
        {
            vendedor = 2;
            comprarArma.enabled = true;
        }
        if (other.gameObject.tag == "Vendedor3")
        {
            vendedor = 3;
            comprarArma.enabled = true;
        }
        if (other.gameObject.tag == "Vendedor4")
        {
            vendedor = 4;
            comprarArma.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        vendedor = 0;
        comprarArma.enabled = false;
    }
}
