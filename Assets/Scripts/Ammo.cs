using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    float lifeTime;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.position += transform.forward * speed;
    }

    void OnCollisionEnter()
    {
        Debug.Log("Col");
        Destroy(gameObject);
    }

}