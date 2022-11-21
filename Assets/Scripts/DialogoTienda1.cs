using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoTienda1 : MonoBehaviour
{
    [SerializeField] Text ArmasBasicas;
    // Start is called before the first frame update
    void Start()
    {
        ArmasBasicas = GameObject.FindGameObjectWithTag("ArmasBasicas").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ArmasBasicas.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ArmasBasicas.enabled = false;
        }
    }
}
