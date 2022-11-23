using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] Money MN;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene() 
    {
        MN.wave = 1;
        MN.money = 0;
        BuyGun.armaUsar = 0;
        SceneManager.LoadScene("Shop");
        
    }
}
