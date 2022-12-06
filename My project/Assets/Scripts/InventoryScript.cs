using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool InventoryIsOpen = false;
    public GameObject InventoryMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(InventoryIsOpen)
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
        InventoryMenuUI.SetActive(false);
        Time.timeScale = 1f;
        InventoryIsOpen = false;
    }

    public void Pause()
    {
        InventoryMenuUI.SetActive(true);
        Time.timeScale = 0f;
        InventoryIsOpen = true;
    }

}
