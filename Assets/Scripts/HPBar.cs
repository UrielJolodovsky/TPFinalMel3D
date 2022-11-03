using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    private Image Display;

    public Player PM;

    // Start is called before the first frame update
    void Start()
    {
        Display = GetComponent<Image>();
        if (PM)
        {
            PM = GameObject.FindObjectOfType<Player>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (PM)
        {
            Display.fillAmount = PM.ActualHealth / PM.Health;
        }
    }
}