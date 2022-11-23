using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveManager : MonoBehaviour
{
    [SerializeField]
    Money MN;
    [SerializeField]
    Transform S1;
    [SerializeField]
    Transform S2;
    [SerializeField]
    float Time;
    [SerializeField]
    float ActualTime;
    [SerializeField]
    int Enemies;
    public int TotalEnemies;
    [SerializeField]
    GameObject Zombie;
    [SerializeField]
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Enemies = MN.wave * 2;
        ActualTime = Time;
        TotalEnemies = Enemies;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Enemies > 0 && ActualTime >= 0)
        {
            ActualTime--;
        }
        if(Enemies > 0 && ActualTime < 0)
        {
            Instantiate(Zombie, S1.transform.position, Quaternion.identity);
            Instantiate(Zombie, S2.transform.position, Quaternion.identity);
            Enemies -= 2;
            ActualTime = Time;
        }
        if(TotalEnemies <= 0)
        {
            MN.money += 20;
            MN.wave++;
            player.transform.position = BuyGun.spawn;
            SceneManager.LoadScene("Shop");
            
        }
        if(MN.wave >= 7)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
