using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    int Health;
    WaveManager WM;

    // Start is called before the first frame update
    void Start()
    {
        WM = FindObjectOfType<WaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            WM.TotalEnemies--;
            Destroy(gameObject);    
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ammo"))
        {
            Health--;
        }
    }
}
