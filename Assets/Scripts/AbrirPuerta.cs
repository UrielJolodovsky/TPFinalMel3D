using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbrirPuerta : MonoBehaviour
{
    [SerializeField] bool Abrible;
    [SerializeField] bool Abrierta;
    [SerializeField] public Text RangoAbrir;
    [SerializeField] public BoxCollider TriggerCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Abrible == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
               GetComponent<Animator>().SetBool("Abrir", true);
               GetComponent<Animator>().SetBool("Abierta", true);
               RangoAbrir.enabled = false;
               TriggerCollider.enabled = false;
            }
        }
    }
    void OnTriggerStay()
    {
        Abrible = true;
        RangoAbrir.enabled = true;
    }
    void OnTriggerExit()
    {
        RangoAbrir.enabled = false;
    }
}
