using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{

    public static bool ChestIsOpen = false;
    public GameObject ChestUI;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (ChestIsOpen)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        } 
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
}
