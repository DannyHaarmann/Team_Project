using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    Vector3 pos;
    public static bool ChestIsOpen = false;
    private bool isChest;
    private bool onSword;
    private bool onPotion;
    private bool onSpeedPot;
    public GameObject ChestUI;
    public GameObject HealthUI;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = pos;
            if (isChest)
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
        else if(coll.tag == "Sword")
        {
            onSword = true;  
        }
        else if(coll.tag == "Potion")
        {
            onPotion = true;
        }
        else if (coll.tag == "SpeedPot")
        {
            onSpeedPot = true;
        }
    }

    public bool checkSword()
    {
        if(onSword == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool checkPotion()
    {
        if(onPotion == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool checkSpeedPot()
    {
        if(onSpeedPot == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Chest")
        {
            isChest = false;
        }
        else if(coll.tag == "Sword")
        {
            onSword = false;
        }
        else if (coll.tag == "Potion")
        {
            onPotion = false;
        }
        else if(coll.tag == "SpeedPot")
        {
            onSpeedPot = false;
        }
    }

    public void Resume()
    {
        this.ChestUI.SetActive(false);
        HealthUI.SetActive(true);
        Time.timeScale = 1f;
        ChestIsOpen = false;
        transform.localPosition = new Vector3();
    }

    public void Pause()
    {
        this.ChestUI.SetActive(true);
        HealthUI.SetActive(false);
        Time.timeScale = 0f;
        ChestIsOpen = true;
        transform.localPosition = new Vector3();
    }
}
