using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    void Start()
    {

        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        transform.position += transform.forward * speed;

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Col");
        Destroy(gameObject);
    }

}