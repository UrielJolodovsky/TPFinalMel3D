using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    [SerializeField] Image Display;
    public Player PM;

    // Start is called before the first frame update
    void Start()
    {
        Display = GetComponent<Image>();
        PM = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Display.fillAmount = PM.ActualHealth / PM.Health;
    }
}