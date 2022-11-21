using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn = null;
    public float reloadTime;
    public float inacuracy;
    float currReloadTime;
    AudioSource Sound;
    [SerializeField] GameObject BalaEfecto;
    [SerializeField] PostProcessVolume post;
    [SerializeField] Bloom bloom;
    [SerializeField] float counter;

    //bool canShoot = true;
    void Start()
    {
        currReloadTime = reloadTime;
        Sound = GetComponent<AudioSource>();
        BalaEfecto = GameObject.FindGameObjectWithTag("post");
        post = BalaEfecto.GetComponent<PostProcessVolume>();
        post.profile.TryGetSettings(out bloom);
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
            // Seria posible instanciar 2? Asi el bloom no queda raro. 
            b.transform.eulerAngles += new Vector3(Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy), Random.Range(-inacuracy, inacuracy));
            currReloadTime = reloadTime;
            bloom.intensity.value = 10;
            counter += .09f;
            if(counter >= .1f) 
            {
                bloom.intensity.value = 0;
                counter = 0;
            }
        }
        if (BuyGun.armaUsar == 1)
        {
            // Arma Verde
        }
        if (BuyGun.armaUsar == 2)
        {
            // Arma Aul
        }
        if (BuyGun.armaUsar == 3)
        {
            // Arma Roja
        }
        if (BuyGun.armaUsar == 4)
        {
            // Arma Amarilla
        }
    }
}