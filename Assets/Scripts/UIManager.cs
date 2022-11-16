using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] Money MN;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SendToZombies();
        }
    }
    
    
    
    public void SendToZombies()
    {
        Debug.Log("Sending to zombies");
        SceneManager.LoadScene("Zombies");
    }
}
