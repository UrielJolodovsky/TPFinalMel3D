using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int Health;
    public int ActualHealth;
    
    
    // Start is called before the first frame update
    void Start()
    {
        ActualHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health--;
        }
    }
}
