using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{

    public static bool ChestIsOpen = false;
    private bool isChest;
    public GameObject ChestUI;
    public GameObject HealthUI;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(isChest)
            {
                if (Input.GetKeyDown("e"))
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
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Chest")
        {
            isChest = true;
        }
    }

    public void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Chest")
        {
            isChest = false;
        }
    }

    public void Resume()
    {
        this.ChestUI.SetActive(false);
        HealthUI.SetActive(true);
        Time.timeScale = 1f;
        ChestIsOpen = false;
    }

    public void Pause()
    {
        this.ChestUI.SetActive(true);
        HealthUI.SetActive(false);
        Time.timeScale = 0f;
        ChestIsOpen = true;
    }
}
