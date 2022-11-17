using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn = null;
    public float reloadTime;
    public float inacuracy;
    float currReloadTime;
    AudioSource Sound;

    //bool canShoot = true;
    void Start()
    {
        currReloadTime = reloadTime;
        Sound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (currReloadTime > 0)
        {
            currReloadTime -= Time.deltaTime;
        }
        if (Input.GetMouseButton(0) && currReloadTime <= 0)
        {
            if (Sound)
            {
                Sound.Play();
            }
            var b = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            b.transform.eulerAngles += new Vector3(Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy));
            currReloadTime = reloadTime;
        }
    }
}