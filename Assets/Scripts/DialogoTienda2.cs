using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoTienda2 : MonoBehaviour
{
    [SerializeField] Text Armas2;
    // Start is called before the first frame update
    void Start()
    {
        Armas2 = GameObject.FindGameObjectWithTag("Armas2").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Armas2.enabled = true;
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        Armas2.enabled = false;
    }
}