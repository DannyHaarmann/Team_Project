using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{

    public static bool ChestIsOpen = false;
    public GameObject ChestUI;
    public GameObject Player;
    public GameObject item;
    

    // Update is called once per frame
    void Update()
    {

    }

    public void Resume()
    {
        ChestUI.SetActive(false);
        
        Time.timeScale = 1f;
        ChestIsOpen = false;
    }

    public void Pause()
    {
        ChestUI.SetActive(true);
        
        Time.timeScale = 0f;
        ChestIsOpen = true;
    }

    public void addHealth()
    {
        Player.GetComponent<PlayerController>().addHealth(10);
        item.SetActive(false);
    }
}
