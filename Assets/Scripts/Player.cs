using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Player : MonoBehaviour
{
    [SerializeField] public float Health;
    public float ActualHealth;
    [SerializeField] GameObject Sangre;
    [SerializeField] PostProcessVolume post;
    [SerializeField] Vignette vignet;

    // Start is called before the first frame update
    void Start()
    {
        ActualHealth = Health;
        Sangre = GameObject.FindGameObjectWithTag("post");
        post = Sangre.GetComponent<PostProcessVolume>();
        post.profile.TryGetSettings(out vignet);
    }

    // Update is called once per frame
    void Update()
    {
        vignet.intensity.value = -ActualHealth;
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ActualHealth--;
            if (ActualHealth <= -1)
            {
                Time.timeScale = 0;
            }
        }
    }
}
